namespace LotroSignatures
{
    partial class Step3
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
            this.kinName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kinType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kinRank = new System.Windows.Forms.ComboBox();
            this.noKin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // kinName
            // 
            this.kinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kinName.Location = new System.Drawing.Point(27, 106);
            this.kinName.Name = "kinName";
            this.kinName.Size = new System.Drawing.Size(337, 23);
            this.kinName.TabIndex = 1;
            this.kinName.TextChanged += new System.EventHandler(this.kinName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // kinType
            // 
            this.kinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kinType.FormattingEnabled = true;
            this.kinType.Location = new System.Drawing.Point(27, 168);
            this.kinType.Name = "kinType";
            this.kinType.Size = new System.Drawing.Size(337, 24);
            this.kinType.TabIndex = 3;
            this.kinType.SelectedIndexChanged += new System.EventHandler(this.kinType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 4;
            // 
            // kinRank
            // 
            this.kinRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kinRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kinRank.FormattingEnabled = true;
            this.kinRank.Items.AddRange(new object[] {
            "Recruit",
            "Member",
            "Officer",
            "Founder",
            "Leader"});
            this.kinRank.Location = new System.Drawing.Point(27, 257);
            this.kinRank.Name = "kinRank";
            this.kinRank.Size = new System.Drawing.Size(337, 24);
            this.kinRank.TabIndex = 5;
            this.kinRank.SelectedIndexChanged += new System.EventHandler(this.kinRank_SelectedIndexChanged);
            // 
            // noKin
            // 
            this.noKin.AutoSize = true;
            this.noKin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noKin.Location = new System.Drawing.Point(27, 28);
            this.noKin.Name = "noKin";
            this.noKin.Size = new System.Drawing.Size(15, 14);
            this.noKin.TabIndex = 6;
            this.noKin.UseVisualStyleBackColor = true;
            this.noKin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Step3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noKin);
            this.Controls.Add(this.kinRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kinType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kinName);
            this.Controls.Add(this.label1);
            this.Name = "Step3";
            this.Size = new System.Drawing.Size(406, 335);
            this.Load += new System.EventHandler(this.Step3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kinName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kinType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kinRank;
        private System.Windows.Forms.CheckBox noKin;
    }
}
