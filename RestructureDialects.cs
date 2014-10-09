// Copyright (c) 2014 SIL International
// Licensed under the MIT license: opensource.org/licenses/MIT
// Created by Jonathan Coombs (SIL), Sep 2014

using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIL.FieldWorks.FDO;
using SIL.FieldWorks.XWorks;

namespace MacroRestructureDialects
{
    /// <summary>
    /// To make this FLEx macro show up in the Tools menu, drop the resulting DLL into output/debug (or wherever FLEx is executing).
    /// This macro switches which dialect is the 'primary' or 'reference' dialect the project focuses on. 
    /// It does this by swapping the two fields that are stored in a Dialect Variant with the same two fields in the main entry.
    /// The 'winning' variant must fit the control string best, and the main entry must fail to cover the main dialect. 
    /// These examples assume the macro was asked to produce 'SNW':
    /// - variants ('SW', 'S', 'N') of an 'NW' main entry: the 'SW' variant wins. ('SW' is more complete than 'S'.)
    /// - variant ('N') of a 'W' main entry: the 'N' variant wins. (Since the control is 'SNW', not 'SWN'.)
    /// - variants ('SNW', 'S', 'SN') of an 'S' main entry: no change. ('SNW' is best, but the main entry is 'good enough'.)
    /// - variant ('S') of an unmarked main entry: no change. (We don't know enough.)
    /// For WARNINGS, see the constant below (and RestructureDialectsDialog.cs)
    /// </summary>
    public class RestructureDialects : IFlexMacro
    {
        public const string Warnings =
@"and swap the pair of fields with the main entry's pair. Each dialect should use a unique one-letter code.

WARNINGS:
- The Summary Definition field must be used exclusively as a Dialect Labels field. (I.e. it's been hijacked.)
- For dialectal variants, the ONLY fields that should be filled in are Lexeme Form and Summary Definition.
  All other fields should go on the main entry, since they will not be swapped.
- Where there are multiple variants that beat the main entry, an arbitrary winner will be chosen.
- If anything goes wrong, filter the main Lexeme Form for } or {, since a backup like this is placed there first:
  coke[W] {pop[NS]}";

        private const string DialectalVariantName = "Dialectal Variant";

        // =====================================================
        // Methods required by the macro interface...

        public string CommandName
        {
            get { return "Restructure dialectal variants"; }
        }

        public bool Enabled(ICmObject target, int targetField, int wsId, int start, int length)
        {
            if (target != null) return true;  //TODO: figure out how to not need target
        }


        /// <summary>
        /// The required main method with required signature.
        /// </summary>
        public void RunMacro(ICmObject target, int targetField, int wsId, int start, int length)
        {
            Main(target);
        }

        public Keys PreferredFunctionKey
        {
            get { return Keys.F8; }
        }


        // =====================================================
        // Things needed by the task itself...

        private void Main(ICmObject target)
        {
            var f = new RestructureDialectsDialog();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.Cancel) return;

            var esb = new StringBuilder();
            esb.AppendLine("Original pairs prior to swapping: ");

            //var sda = target.Cache.DomainDataByFlid;

            //TODO: figure out how to not need target

            ILexEntryRepository repo = target.Cache.ServiceLocator.GetInstance<ILexEntryRepository>();
            var wsRepo = target.Cache.ServiceLocator.GetInstance<IWritingSystemContainer>();
            _vern = wsRepo.DefaultVernacularWritingSystem.Handle;
            _ana = wsRepo.DefaultAnalysisWritingSystem.Handle;

            int i = 0;
            int max = f.GetMaxToProcess();
            foreach (ILexEntry entry in repo.AllInstances())
            {
                if (i >= max) break;

                ILexEntry vWinner = GetWinningVariant(entry, f.GetPeckingOrder());

                if (vWinner != null)
                {
                    // There is a dialectal variant we need to swap with
                    string s = Swap(entry, vWinner);
                    i++;
                    if (i<15)
                    {
                        esb.AppendLine(s);
                    }
                    else if(i == 15)
                    {
                        esb.AppendLine("...");
                    }
                }
            }

            MessageBox.Show(esb.ToString(), f.GetPeckingOrder() + ": Made " + i + " swaps. Done restructuring.");

        }

        private string Swap(ILexEntry entry, ILexEntry vWinner)
        {
            string lexeme = GetLexeme(entry);
            string dialects = GetDialects(entry);
            string vLexeme = GetLexeme(vWinner);
            string vDialects = GetDialects(vWinner);

            // first, "back up" a complete copy of the data in the main entry (in case we crash)
            string complete = String.Format("{0}[{1}] {{{2}[{3}]}}", lexeme, dialects, vLexeme, vDialects);
            SetLexeme(entry, complete); 

            SetDialects(entry, vDialects);
            SetLexeme(vWinner, lexeme);
            SetDialects(vWinner, dialects);
            SetLexeme(entry, vLexeme); //overwrite the backup

            return complete;
        }

        /// <summary>
        /// Returns the variant to be swapped with, or null if no swap is needed.
        /// </summary>
        private ILexEntry GetWinningVariant(ILexEntry mainEntry, string peckingOrder)
        {
            string mainDialect = peckingOrder.Substring(0,1);
            string d = GetDialects(mainEntry);
            if (String.IsNullOrEmpty(d) || d.Contains(mainDialect))
            {
                return null; // main entry is already fine, or we don't know enough about its dialect
            }

            if (mainEntry.VariantFormEntries == null)
            {
                return null; // filter out anything that's not a main entry with variants
            }

            var vcoll = mainEntry.VariantFormEntries.ToList();

            if (vcoll.Count < 1)
            {
                return null; // filter out anything that's not a main entry with variants
            }

            ILexEntry winner = null;
            foreach (var variant in vcoll)
            {
                if (!IsDialectalVariant(variant)) continue; // filter/ignore anything that's not a dialectal variant

                if (winner == null) // first dialectal variant we've looked at
                {
                    winner = Compare(mainEntry, variant, peckingOrder);
                }
                else  // additional dialectal variants
                {
                    winner = Compare(winner, variant, peckingOrder);
                }

            }
            if (winner == mainEntry) winner = null;

            return winner;
        }

        /// <summary>
        /// Given two entries, returns the better of the two entries, or entry1 if neither is better.
        /// </summary>
        private ILexEntry Compare(ILexEntry entry1, ILexEntry entry2, string peckingOrder)
        {
            string d1 = GetDialects(entry1);
            string d2 = GetDialects(entry2);
            foreach(var c in peckingOrder)
            {
                if (!d2.Contains(c)) return entry1;
                if (!d1.Contains(c)) return entry2; 
            }
            return entry1;
        }


        // =====================================================
        // Things needed just for accessing the FLEx data model...

        private int _vern;
        private int _ana;
        private readonly SpecialWritingSystemCodes _anaBest = SpecialWritingSystemCodes.BestAnalysis;
        private string _dvName = DialectalVariantName;

        //private ILexEntry _main;
        //private ILexEntry _winningVariant;
        //private string _winningLx; //cache, just for speed
        //private string _winningSumm; //cache, just for speed

        private bool IsDialectalVariant(ILexEntry variant)
        {
            foreach (var t in variant.VariantEntryRefs)
            {
                foreach (var t2 in t.VariantEntryTypesRS)  // not sure why this extra loop is needed (an FDO complexity...)
                {
                    string tmp = t2.Name.GetAlternative(_anaBest);
                    if (tmp == _dvName)
                    {
                        // One of this entry's Variant Types is the dialectal variant type
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Gets the default-vernacular-WS part of the Lexeme Form field of this entry.
        /// </summary>
        private string GetLexeme(ILexEntry entry)
        {
            return entry.LexemeFormOA.Form.get_String(_vern).Text;
        }
        /// <summary>
        /// See getLexeme()
        /// </summary>
        private void SetLexeme(ILexEntry entry, string val)
        {
            entry.LexemeFormOA.Form.set_String(_vern, val);
        }

        /// <summary>
        /// Gets the default-analysis-WS part of a plain-text field that contains one single-character code for each 
        /// dialect the entry applies to. Currently, a hijacked Summary Def is just about the only field usable for 
        /// this purpose that is also decently publishable.
        /// </summary>
        private string GetDialects(ILexEntry entry)
        {
            string s = entry.SummaryDefinition.get_String(_ana).Text;
            if (s == null) return "";
            return s;
        }
        /// <summary>
        /// See getDialects()
        /// </summary>
        private void SetDialects(ILexEntry entry, string val)
        {
            entry.SummaryDefinition.set_String(_ana, val);
        }

    }
}
