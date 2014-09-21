// Copyright (c) 2014 SIL International
// Licensed under the MIT license: opensource.org/licenses/MIT

namespace MacroRestructureDialects
{
    partial class RestructureDialectsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestructureDialectsDialog));
            this.tableNested = new System.Windows.Forms.TableLayoutPanel();
            this.DialectOrderTextBox = new System.Windows.Forms.TextBox();
            this.VariantTypeTextBox = new System.Windows.Forms.TextBox();
            this.DialectFieldTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.maxEntriesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.tableNested.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxEntriesNumericUpDown)).BeginInit();
            this.flowLayoutButtons.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableNested
            // 
            this.tableNested.ColumnCount = 2;
            this.tableNested.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNested.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableNested.Controls.Add(this.DialectOrderTextBox, 1, 3);
            this.tableNested.Controls.Add(this.VariantTypeTextBox, 1, 2);
            this.tableNested.Controls.Add(this.DialectFieldTextBox, 1, 0);
            this.tableNested.Controls.Add(this.textBox1, 0, 0);
            this.tableNested.Controls.Add(this.textBox2, 0, 2);
            this.tableNested.Controls.Add(this.textBox3, 0, 3);
            this.tableNested.Controls.Add(this.textBox5, 0, 1);
            this.tableNested.Controls.Add(this.maxEntriesNumericUpDown, 1, 1);
            this.tableNested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableNested.Location = new System.Drawing.Point(3, 3);
            this.tableNested.Name = "tableNested";
            this.tableNested.RowCount = 4;
            this.tableNested.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableNested.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableNested.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableNested.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableNested.Size = new System.Drawing.Size(510, 149);
            this.tableNested.TabIndex = 0;
            // 
            // DialectOrderTextBox
            // 
            this.DialectOrderTextBox.Location = new System.Drawing.Point(379, 114);
            this.DialectOrderTextBox.Name = "DialectOrderTextBox";
            this.DialectOrderTextBox.Size = new System.Drawing.Size(120, 20);
            this.DialectOrderTextBox.TabIndex = 0;
            this.DialectOrderTextBox.Text = "NSW";
            // 
            // VariantTypeTextBox
            // 
            this.VariantTypeTextBox.Location = new System.Drawing.Point(379, 77);
            this.VariantTypeTextBox.Name = "VariantTypeTextBox";
            this.VariantTypeTextBox.ReadOnly = true;
            this.VariantTypeTextBox.Size = new System.Drawing.Size(120, 20);
            this.VariantTypeTextBox.TabIndex = 6;
            this.VariantTypeTextBox.TabStop = false;
            this.VariantTypeTextBox.Text = "Dialectal Variant";
            // 
            // DialectFieldTextBox
            // 
            this.DialectFieldTextBox.Location = new System.Drawing.Point(379, 3);
            this.DialectFieldTextBox.Name = "DialectFieldTextBox";
            this.DialectFieldTextBox.ReadOnly = true;
            this.DialectFieldTextBox.Size = new System.Drawing.Size(120, 20);
            this.DialectFieldTextBox.TabIndex = 4;
            this.DialectFieldTextBox.TabStop = false;
            this.DialectFieldTextBox.Text = "Summary Definition";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(370, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "The \"DialectLabels\" field that entries are marked with is:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(3, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(370, 31);
            this.textBox2.TabIndex = 2;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "For a pair of fields (Lexeme and Dialect Labels) found on variant(s) of type...";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(3, 114);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(370, 32);
            this.textBox3.TabIndex = 3;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "whose main entry is marked and doesn\'t already apply to the primary dialect, sele" +
                "ct a winner by this priority...";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(3, 40);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(370, 31);
            this.textBox5.TabIndex = 1;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Maximum number of entries to process now:";
            // 
            // maxEntriesNumericUpDown
            // 
            this.maxEntriesNumericUpDown.Location = new System.Drawing.Point(379, 40);
            this.maxEntriesNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxEntriesNumericUpDown.Name = "maxEntriesNumericUpDown";
            this.maxEntriesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxEntriesNumericUpDown.TabIndex = 5;
            this.maxEntriesNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.maxEntriesNumericUpDown.ValueChanged += new System.EventHandler(this.maxEntriesNumericUpDown_ValueChanged);
            // 
            // flowLayoutButtons
            // 
            this.flowLayoutButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutButtons.Controls.Add(this.OkButton);
            this.flowLayoutButtons.Controls.Add(this.CancelButton);
            this.flowLayoutButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutButtons.Location = new System.Drawing.Point(347, 294);
            this.flowLayoutButtons.Name = "flowLayoutButtons";
            this.flowLayoutButtons.Size = new System.Drawing.Size(166, 27);
            this.flowLayoutButtons.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(88, 3);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(7, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.tableNested, 0, 0);
            this.tableMain.Controls.Add(this.flowLayoutButtons, 0, 2);
            this.tableMain.Controls.Add(this.textBoxDetails, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMain.Size = new System.Drawing.Size(516, 324);
            this.tableMain.TabIndex = 1;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDetails.Location = new System.Drawing.Point(3, 158);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.Size = new System.Drawing.Size(510, 123);
            this.textBoxDetails.TabIndex = 7;
            this.textBoxDetails.TabStop = false;
            this.textBoxDetails.Text = resources.GetString("textBoxDetails.Text");
            // 
            // RestructureDialectsDialog
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 324);
            this.Controls.Add(this.tableMain);
            this.Name = "RestructureDialectsDialog";
            this.Text = "Restructure Dialects";
            this.tableNested.ResumeLayout(false);
            this.tableNested.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxEntriesNumericUpDown)).EndInit();
            this.flowLayoutButtons.ResumeLayout(false);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableNested;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutButtons;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox VariantTypeTextBox;
        private System.Windows.Forms.TextBox DialectOrderTextBox;
        private System.Windows.Forms.TextBox DialectFieldTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown maxEntriesNumericUpDown;
    }
}