namespace LotroSignatures
{
    partial class Step5
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.vocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prof1box = new System.Windows.Forms.GroupBox();
            this.prof1mastery = new System.Windows.Forms.ComboBox();
            this.prof1tier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prof2box = new System.Windows.Forms.GroupBox();
            this.prof2mastery = new System.Windows.Forms.ComboBox();
            this.prof2tier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prof3box = new System.Windows.Forms.GroupBox();
            this.prof3mastery = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prof3tier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.prof1box.SuspendLayout();
            this.prof2box.SuspendLayout();
            this.prof3box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // vocation
            // 
            this.vocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vocation.FormattingEnabled = true;
            this.vocation.Location = new System.Drawing.Point(27, 44);
            this.vocation.Name = "vocation";
            this.vocation.Size = new System.Drawing.Size(337, 24);
            this.vocation.TabIndex = 1;
            this.vocation.SelectedIndexChanged += new System.EventHandler(this.vocation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // prof1box
            // 
            this.prof1box.Controls.Add(this.prof1mastery);
            this.prof1box.Controls.Add(this.prof1tier);
            this.prof1box.Controls.Add(this.label4);
            this.prof1box.Controls.Add(this.label3);
            this.prof1box.Location = new System.Drawing.Point(206, 109);
            this.prof1box.Name = "prof1box";
            this.prof1box.Size = new System.Drawing.Size(197, 92);
            this.prof1box.TabIndex = 3;
            this.prof1box.TabStop = false;
            // 
            // prof1mastery
            // 
            this.prof1mastery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prof1mastery.Enabled = false;
            this.prof1mastery.FormattingEnabled = true;
            this.prof1mastery.Location = new System.Drawing.Point(80, 56);
            this.prof1mastery.Name = "prof1mastery";
            this.prof1mastery.Size = new System.Drawing.Size(110, 21);
            this.prof1mastery.TabIndex = 3;
            this.prof1mastery.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // prof1tier
            // 
            this.prof1tier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prof1tier.Enabled = false;
            this.prof1tier.FormattingEnabled = true;
            this.prof1tier.Location = new System.Drawing.Point(80, 28);
            this.prof1tier.Name = "prof1tier";
            this.prof1tier.Size = new System.Drawing.Size(111, 21);
            this.prof1tier.TabIndex = 2;
            this.prof1tier.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mastery Tier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tier:";
            // 
            // prof2box
            // 
            this.prof2box.Controls.Add(this.prof2mastery);
            this.prof2box.Controls.Add(this.prof2tier);
            this.prof2box.Controls.Add(this.label6);
            this.prof2box.Controls.Add(this.label5);
            this.prof2box.Location = new System.Drawing.Point(3, 207);
            this.prof2box.Name = "prof2box";
            this.prof2box.Size = new System.Drawing.Size(197, 92);
            this.prof2box.TabIndex = 4;
            this.prof2box.TabStop = false;
            // 
            // prof2mastery
            // 
            this.prof2mastery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prof2mastery.Enabled = false;
            this.prof2mastery.FormattingEnabled = true;
            this.prof2mastery.Location = new System.Drawing.Point(80, 56);
            this.prof2mastery.Name = "prof2mastery";
            this.prof2mastery.Size = new System.Drawing.Size(110, 21);
            this.prof2mastery.TabIndex = 7;
            this.prof2mastery.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // prof2tier
            // 
            this.prof2tier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prof2tier.Enabled = false;
            this.prof2tier.FormattingEnabled = true;
            this.prof2tier.Location = new System.Drawing.Point(80, 28);
            this.prof2tier.Name = "prof2tier";
            this.prof2tier.Size = new System.Drawing.Size(111, 21);
            this.prof2tier.TabIndex = 6;
            this.prof2tier.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tier:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mastery Tier:";
            // 
            // prof3box
            // 
            this.prof3box.Controls.Add(this.prof3mastery);
            this.prof3box.Controls.Add(this.label7);
            this.prof3box.Controls.Add(this.prof3tier);
            this.prof3box.Controls.Add(this.label8);
            this.prof3box.Location = new System.Drawing.Point(206, 207);
            this.prof3box.Name = "prof3box";
            this.prof3box.Size = new System.Drawing.Size(197, 92);
            this.prof3box.TabIndex = 5;
            this.prof3box.TabStop = false;
            // 
            // prof3mastery
            // 
            this.prof3mastery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prof3mastery.Enabled = false;
            this.prof3mastery.FormattingEnabled = true;
            this.prof3mastery.Location = new System.Drawing.Point(80, 54);
            this.prof3mastery.Name = "prof3mastery";
            this.prof3mastery.Size = new System.Drawing.Size(110, 21);
            this.prof3mastery.TabIndex = 11;
            this.prof3mastery.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mastery Tier:";
            // 
            // prof3tier
            // 
            this.prof3tier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prof3tier.Enabled = false;
            this.prof3tier.FormattingEnabled = true;
            this.prof3tier.Location = new System.Drawing.Point(80, 26);
            this.prof3tier.Name = "prof3tier";
            this.prof3tier.Size = new System.Drawing.Size(111, 21);
            this.prof3tier.TabIndex = 10;
            this.prof3tier.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tier:";
            // 
            // Step5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prof3box);
            this.Controls.Add(this.prof2box);
            this.Controls.Add(this.prof1box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vocation);
            this.Controls.Add(this.label1);
            this.Name = "Step5";
            this.Size = new System.Drawing.Size(406, 335);
            this.prof1box.ResumeLayout(false);
            this.prof1box.PerformLayout();
            this.prof2box.ResumeLayout(false);
            this.prof2box.PerformLayout();
            this.prof3box.ResumeLayout(false);
            this.prof3box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox prof1box;
        private System.Windows.Forms.GroupBox prof2box;
        private System.Windows.Forms.GroupBox prof3box;
        private System.Windows.Forms.ComboBox prof1mastery;
        private System.Windows.Forms.ComboBox prof1tier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox prof2mastery;
        private System.Windows.Forms.ComboBox prof2tier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox prof3mastery;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox prof3tier;
        private System.Windows.Forms.Label label8;
    }
}
