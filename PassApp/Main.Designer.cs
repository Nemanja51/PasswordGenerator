namespace PassApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.passLengthCmb = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.generatedPassTxtBox = new System.Windows.Forms.TextBox();
            this.termsLbl = new System.Windows.Forms.Label();
            this.cpecCharsChb = new System.Windows.Forms.CheckBox();
            this.numsChb = new System.Windows.Forms.CheckBox();
            this.numbersLbl = new System.Windows.Forms.Label();
            this.lowercaseChb = new System.Windows.Forms.CheckBox();
            this.smallLettersLbl = new System.Windows.Forms.Label();
            this.includeLbl = new System.Windows.Forms.Label();
            this.uppercaseLettersChb = new System.Windows.Forms.CheckBox();
            this.uppercaseLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.savePassFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.decryptLbl = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.decryptTxtBox = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.decryptedPassLbl = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.copyToClipboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passLengthCmb)).BeginInit();
            this.SuspendLayout();
            // 
            // passLengthCmb
            // 
            this.passLengthCmb.Location = new System.Drawing.Point(163, 21);
            this.passLengthCmb.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.passLengthCmb.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.passLengthCmb.Name = "passLengthCmb";
            this.passLengthCmb.Size = new System.Drawing.Size(150, 27);
            this.passLengthCmb.TabIndex = 0;
            this.passLengthCmb.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password lenght";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(219, 227);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(94, 29);
            this.generateBtn.TabIndex = 3;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // generatedPassTxtBox
            // 
            this.generatedPassTxtBox.Location = new System.Drawing.Point(22, 274);
            this.generatedPassTxtBox.Name = "generatedPassTxtBox";
            this.generatedPassTxtBox.ReadOnly = true;
            this.generatedPassTxtBox.Size = new System.Drawing.Size(291, 27);
            this.generatedPassTxtBox.TabIndex = 4;
            // 
            // termsLbl
            // 
            this.termsLbl.AutoSize = true;
            this.termsLbl.Location = new System.Drawing.Point(12, 92);
            this.termsLbl.Name = "termsLbl";
            this.termsLbl.Size = new System.Drawing.Size(65, 20);
            this.termsLbl.TabIndex = 6;
            this.termsLbl.Text = "Symbols";
            // 
            // cpecCharsChb
            // 
            this.cpecCharsChb.AutoSize = true;
            this.cpecCharsChb.Location = new System.Drawing.Point(163, 92);
            this.cpecCharsChb.Name = "cpecCharsChb";
            this.cpecCharsChb.Size = new System.Drawing.Size(18, 17);
            this.cpecCharsChb.TabIndex = 7;
            this.cpecCharsChb.UseVisualStyleBackColor = true;
            // 
            // numsChb
            // 
            this.numsChb.AutoSize = true;
            this.numsChb.Location = new System.Drawing.Point(163, 126);
            this.numsChb.Name = "numsChb";
            this.numsChb.Size = new System.Drawing.Size(18, 17);
            this.numsChb.TabIndex = 9;
            this.numsChb.UseVisualStyleBackColor = true;
            // 
            // numbersLbl
            // 
            this.numbersLbl.AutoSize = true;
            this.numbersLbl.Location = new System.Drawing.Point(12, 126);
            this.numbersLbl.Name = "numbersLbl";
            this.numbersLbl.Size = new System.Drawing.Size(69, 20);
            this.numbersLbl.TabIndex = 8;
            this.numbersLbl.Text = "Numbers";
            // 
            // lowercaseChb
            // 
            this.lowercaseChb.AutoSize = true;
            this.lowercaseChb.Location = new System.Drawing.Point(163, 160);
            this.lowercaseChb.Name = "lowercaseChb";
            this.lowercaseChb.Size = new System.Drawing.Size(18, 17);
            this.lowercaseChb.TabIndex = 11;
            this.lowercaseChb.UseVisualStyleBackColor = true;
            // 
            // smallLettersLbl
            // 
            this.smallLettersLbl.AutoSize = true;
            this.smallLettersLbl.Location = new System.Drawing.Point(12, 160);
            this.smallLettersLbl.Name = "smallLettersLbl";
            this.smallLettersLbl.Size = new System.Drawing.Size(118, 20);
            this.smallLettersLbl.TabIndex = 10;
            this.smallLettersLbl.Text = "Lowercase Chars";
            // 
            // includeLbl
            // 
            this.includeLbl.AutoSize = true;
            this.includeLbl.Location = new System.Drawing.Point(12, 62);
            this.includeLbl.Name = "includeLbl";
            this.includeLbl.Size = new System.Drawing.Size(60, 20);
            this.includeLbl.TabIndex = 12;
            this.includeLbl.Text = "Include:";
            // 
            // uppercaseLettersChb
            // 
            this.uppercaseLettersChb.AutoSize = true;
            this.uppercaseLettersChb.Location = new System.Drawing.Point(163, 193);
            this.uppercaseLettersChb.Name = "uppercaseLettersChb";
            this.uppercaseLettersChb.Size = new System.Drawing.Size(18, 17);
            this.uppercaseLettersChb.TabIndex = 14;
            this.uppercaseLettersChb.UseVisualStyleBackColor = true;
            // 
            // uppercaseLbl
            // 
            this.uppercaseLbl.AutoSize = true;
            this.uppercaseLbl.Location = new System.Drawing.Point(12, 193);
            this.uppercaseLbl.Name = "uppercaseLbl";
            this.uppercaseLbl.Size = new System.Drawing.Size(119, 20);
            this.uppercaseLbl.TabIndex = 13;
            this.uppercaseLbl.Text = "Uppercase Chars";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(174, 320);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(139, 29);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Save in text file";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // decryptLbl
            // 
            this.decryptLbl.AutoSize = true;
            this.decryptLbl.Location = new System.Drawing.Point(22, 368);
            this.decryptLbl.Name = "decryptLbl";
            this.decryptLbl.Size = new System.Drawing.Size(128, 20);
            this.decryptLbl.TabIndex = 16;
            this.decryptLbl.Text = "Decrypt password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(346, 241);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // decryptTxtBox
            // 
            this.decryptTxtBox.Location = new System.Drawing.Point(22, 391);
            this.decryptTxtBox.Name = "decryptTxtBox";
            this.decryptTxtBox.Size = new System.Drawing.Size(291, 27);
            this.decryptTxtBox.TabIndex = 18;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(219, 436);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(94, 29);
            this.decryptBtn.TabIndex = 19;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // decryptedPassLbl
            // 
            this.decryptedPassLbl.AutoSize = true;
            this.decryptedPassLbl.Location = new System.Drawing.Point(22, 440);
            this.decryptedPassLbl.Name = "decryptedPassLbl";
            this.decryptedPassLbl.Size = new System.Drawing.Size(0, 20);
            this.decryptedPassLbl.TabIndex = 20;
            // 
            // copyToClipboard
            // 
            this.copyToClipboard.Location = new System.Drawing.Point(163, 487);
            this.copyToClipboard.Name = "copyToClipboard";
            this.copyToClipboard.Size = new System.Drawing.Size(150, 29);
            this.copyToClipboard.TabIndex = 21;
            this.copyToClipboard.Text = "Copy To Clipboard";
            this.copyToClipboard.UseVisualStyleBackColor = true;
            this.copyToClipboard.Click += new System.EventHandler(this.copyToClipboard_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(343, 528);
            this.Controls.Add(this.copyToClipboard);
            this.Controls.Add(this.decryptedPassLbl);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.decryptTxtBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.decryptLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.uppercaseLettersChb);
            this.Controls.Add(this.uppercaseLbl);
            this.Controls.Add(this.includeLbl);
            this.Controls.Add(this.lowercaseChb);
            this.Controls.Add(this.smallLettersLbl);
            this.Controls.Add(this.numsChb);
            this.Controls.Add(this.numbersLbl);
            this.Controls.Add(this.cpecCharsChb);
            this.Controls.Add(this.termsLbl);
            this.Controls.Add(this.generatedPassTxtBox);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLengthCmb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pass Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passLengthCmb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown passLengthCmb;
        private Label label1;
        private Button generateBtn;
        private TextBox generatedPassTxtBox;
        private Label termsLbl;
        private CheckBox cpecCharsChb;
        private CheckBox numsChb;
        private Label numbersLbl;
        private CheckBox lowercaseChb;
        private Label smallLettersLbl;
        private Label includeLbl;
        private CheckBox uppercaseLettersChb;
        private Label uppercaseLbl;
        private Button saveBtn;
        private FolderBrowserDialog savePassFBD;
        private Label decryptLbl;
        private CheckBox checkBox1;
        private TextBox decryptTxtBox;
        private Button decryptBtn;
        private Label decryptedPassLbl;
        private SaveFileDialog saveFileDialog;
        private Button copyToClipboard;
    }
}