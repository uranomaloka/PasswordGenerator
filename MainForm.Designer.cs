namespace Passwort_Generator
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbpsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbsmall = new System.Windows.Forms.CheckBox();
            this.chbLarge = new System.Windows.Forms.CheckBox();
            this.chbNumbers = new System.Windows.Forms.CheckBox();
            this.chbSpecial = new System.Windows.Forms.CheckBox();
            this.cbspecialamount = new System.Windows.Forms.ComboBox();
            this.cbnumberamount = new System.Windows.Forms.ComboBox();
            this.cblargeamount = new System.Windows.Forms.ComboBox();
            this.cbsmallamount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.Location = new System.Drawing.Point(12, 109);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(228, 21);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbpsw
            // 
            this.tbpsw.Location = new System.Drawing.Point(12, 162);
            this.tbpsw.Name = "tbpsw";
            this.tbpsw.Size = new System.Drawing.Size(228, 20);
            this.tbpsw.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output";
            // 
            // chbsmall
            // 
            this.chbsmall.AutoSize = true;
            this.chbsmall.Location = new System.Drawing.Point(12, 12);
            this.chbsmall.Name = "chbsmall";
            this.chbsmall.Size = new System.Drawing.Size(104, 17);
            this.chbsmall.TabIndex = 1;
            this.chbsmall.Text = "Small characters";
            this.chbsmall.UseVisualStyleBackColor = true;
            // 
            // chbLarge
            // 
            this.chbLarge.AutoSize = true;
            this.chbLarge.Location = new System.Drawing.Point(133, 12);
            this.chbLarge.Name = "chbLarge";
            this.chbLarge.Size = new System.Drawing.Size(107, 17);
            this.chbLarge.TabIndex = 2;
            this.chbLarge.Text = "Large Characters";
            this.chbLarge.UseVisualStyleBackColor = true;
            // 
            // chbNumbers
            // 
            this.chbNumbers.AutoSize = true;
            this.chbNumbers.Location = new System.Drawing.Point(12, 59);
            this.chbNumbers.Name = "chbNumbers";
            this.chbNumbers.Size = new System.Drawing.Size(68, 17);
            this.chbNumbers.TabIndex = 3;
            this.chbNumbers.Text = "Numbers";
            this.chbNumbers.UseVisualStyleBackColor = true;
            // 
            // chbSpecial
            // 
            this.chbSpecial.AutoSize = true;
            this.chbSpecial.Location = new System.Drawing.Point(133, 59);
            this.chbSpecial.Name = "chbSpecial";
            this.chbSpecial.Size = new System.Drawing.Size(115, 17);
            this.chbSpecial.TabIndex = 4;
            this.chbSpecial.Text = "Special Characters";
            this.chbSpecial.UseVisualStyleBackColor = true;
            // 
            // cbspecialamount
            // 
            this.cbspecialamount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbspecialamount.FormattingEnabled = true;
            this.cbspecialamount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbspecialamount.Location = new System.Drawing.Point(133, 82);
            this.cbspecialamount.Name = "cbspecialamount";
            this.cbspecialamount.Size = new System.Drawing.Size(48, 21);
            this.cbspecialamount.TabIndex = 7;
            // 
            // cbnumberamount
            // 
            this.cbnumberamount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnumberamount.FormattingEnabled = true;
            this.cbnumberamount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbnumberamount.Location = new System.Drawing.Point(12, 82);
            this.cbnumberamount.Name = "cbnumberamount";
            this.cbnumberamount.Size = new System.Drawing.Size(48, 21);
            this.cbnumberamount.TabIndex = 8;
            // 
            // cblargeamount
            // 
            this.cblargeamount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblargeamount.FormattingEnabled = true;
            this.cblargeamount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cblargeamount.Location = new System.Drawing.Point(133, 32);
            this.cblargeamount.Name = "cblargeamount";
            this.cblargeamount.Size = new System.Drawing.Size(48, 21);
            this.cblargeamount.TabIndex = 9;
            // 
            // cbsmallamount
            // 
            this.cbsmallamount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsmallamount.FormattingEnabled = true;
            this.cbsmallamount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbsmallamount.Location = new System.Drawing.Point(12, 32);
            this.cbsmallamount.Name = "cbsmallamount";
            this.cbsmallamount.Size = new System.Drawing.Size(48, 21);
            this.cbsmallamount.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(248, 201);
            this.Controls.Add(this.cbsmallamount);
            this.Controls.Add(this.cblargeamount);
            this.Controls.Add(this.cbnumberamount);
            this.Controls.Add(this.cbspecialamount);
            this.Controls.Add(this.chbSpecial);
            this.Controls.Add(this.chbNumbers);
            this.Controls.Add(this.chbLarge);
            this.Controls.Add(this.chbsmall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbpsw);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbpsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbsmall;
        private System.Windows.Forms.CheckBox chbLarge;
        private System.Windows.Forms.CheckBox chbNumbers;
        private System.Windows.Forms.CheckBox chbSpecial;
        private System.Windows.Forms.ComboBox cbspecialamount;
        private System.Windows.Forms.ComboBox cbnumberamount;
        private System.Windows.Forms.ComboBox cblargeamount;
        private System.Windows.Forms.ComboBox cbsmallamount;
    }
}

