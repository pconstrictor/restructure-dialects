// Copyright (c) 2014 SIL International
// Licensed under the MIT license: opensource.org/licenses/MIT

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestructureDialects
{
    public partial class RestructureDialectsDialog : Form
    {
        public RestructureDialectsDialog()
        {
            InitializeComponent();
            textBoxDetails.Text = @"and swap the pair of fields with the main entry's pair. Each dialect should use a unique one-letter code.

WARNINGS:
- The Summary Definition field must be used exclusively as a Dialect Labels field. (I.e. it's been hijacked.)
- For dialectal variants, the ONLY fields that should be filled in are Lexeme Form and Summary Definition.
  All other fields should go on the main entry, since they will not be swapped.
- Where there are multiple variants that beat the main entry, an arbitrary winner will be chosen.
- If anything goes wrong, filter the main Lexeme Form for } or {, since a backup like this is placed there first:
  coke[W] {pop[NS]}";
        }

        // TODO: add an overloaded constructor here, for passing in default values, and a list of variant types.

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string GetPeckingOrder()
        {
            return this.DialectOrderTextBox.Text;
        }

        public int GetMaxToProcess()
        {
            return (int)Math.Truncate(maxEntriesNumericUpDown.Value);
        }

        private void maxEntriesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // This is likely overkill; somewhat redundant with the Minimum and Maximum properties.
            if (maxEntriesNumericUpDown.Value > int.MaxValue-2)
            {
                maxEntriesNumericUpDown.Value = 100000;
            }
            if (maxEntriesNumericUpDown.Value < 0)
            {
                maxEntriesNumericUpDown.Value = 0;
            }
        }

    }
}
