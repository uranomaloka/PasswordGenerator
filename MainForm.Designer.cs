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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbLength = new System.Windows.Forms.ComboBox();
            this.tbpsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbsmall = new System.Windows.Forms.CheckBox();
            this.chbLarge = new System.Windows.Forms.CheckBox();
            this.chbNumbers = new System.Windows.Forms.CheckBox();
            this.chbSpecial = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.Location = new System.Drawing.Point(106, 25);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(107, 21);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbLength
            // 
            this.cbLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLength.FormattingEnabled = true;
            this.cbLength.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbLength.Location = new System.Drawing.Point(12, 25);
            this.cbLength.Name = "cbLength";
            this.cbLength.Size = new System.Drawing.Size(48, 21);
            this.cbLength.TabIndex = 0;
            // 
            // tbpsw
            // 
            this.tbpsw.Location = new System.Drawing.Point(12, 117);
            this.tbpsw.Name = "tbpsw";
            this.tbpsw.Size = new System.Drawing.Size(201, 20);
            this.tbpsw.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output";
            // 
            // chbsmall
            // 
            this.chbsmall.AutoSize = true;
            this.chbsmall.Location = new System.Drawing.Point(12, 52);
            this.chbsmall.Name = "chbsmall";
            this.chbsmall.Size = new System.Drawing.Size(104, 17);
            this.chbsmall.TabIndex = 1;
            this.chbsmall.Text = "Small characters";
            this.chbsmall.UseVisualStyleBackColor = true;
            // 
            // chbLarge
            // 
            this.chbLarge.AutoSize = true;
            this.chbLarge.Location = new System.Drawing.Point(133, 52);
            this.chbLarge.Name = "chbLarge";
            this.chbLarge.Size = new System.Drawing.Size(107, 17);
            this.chbLarge.TabIndex = 2;
            this.chbLarge.Text = "Large Characters";
            this.chbLarge.UseVisualStyleBackColor = true;
            // 
            // chbNumbers
            // 
            this.chbNumbers.AutoSize = true;
            this.chbNumbers.Location = new System.Drawing.Point(12, 75);
            this.chbNumbers.Name = "chbNumbers";
            this.chbNumbers.Size = new System.Drawing.Size(68, 17);
            this.chbNumbers.TabIndex = 3;
            this.chbNumbers.Text = "Numbers";
            this.chbNumbers.UseVisualStyleBackColor = true;
            // 
            // chbSpecial
            // 
            this.chbSpecial.AutoSize = true;
            this.chbSpecial.Location = new System.Drawing.Point(133, 75);
            this.chbSpecial.Name = "chbSpecial";
            this.chbSpecial.Size = new System.Drawing.Size(115, 17);
            this.chbSpecial.TabIndex = 4;
            this.chbSpecial.Text = "Special Characters";
            this.chbSpecial.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(261, 159);
            this.Controls.Add(this.chbSpecial);
            this.Controls.Add(this.chbNumbers);
            this.Controls.Add(this.chbLarge);
            this.Controls.Add(this.chbsmall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbpsw);
            this.Controls.Add(this.cbLength);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbLength;
        private System.Windows.Forms.TextBox tbpsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbsmall;
        private System.Windows.Forms.CheckBox chbLarge;
        private System.Windows.Forms.CheckBox chbNumbers;
        private System.Windows.Forms.CheckBox chbSpecial;
    }
}

