namespace LotroSignatures
{
    partial class Step4
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
            this.doingPvp = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.starIndicator = new System.Windows.Forms.Label();
            this.stars = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stars)).BeginInit();
            this.SuspendLayout();
            // 
            // doingPvp
            // 
            this.doingPvp.AutoSize = true;
            this.doingPvp.Checked = true;
            this.doingPvp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doingPvp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doingPvp.Location = new System.Drawing.Point(27, 28);
            this.doingPvp.Name = "doingPvp";
            this.doingPvp.Size = new System.Drawing.Size(15, 14);
            this.doingPvp.TabIndex = 0;
            this.doingPvp.UseVisualStyleBackColor = true;
            this.doingPvp.CheckedChanged += new System.EventHandler(this.doingPvp_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.starIndicator);
            this.groupBox1.Controls.Add(this.stars);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rank);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // starIndicator
            // 
            this.starIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.starIndicator.AutoSize = true;
            this.starIndicator.Location = new System.Drawing.Point(272, 187);
            this.starIndicator.Name = "starIndicator";
            this.starIndicator.Size = new System.Drawing.Size(0, 13);
            this.starIndicator.TabIndex = 6;
            // 
            // stars
            // 
            this.stars.LargeChange = 1;
            this.stars.Location = new System.Drawing.Point(12, 139);
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(335, 45);
            this.stars.TabIndex = 5;
            this.stars.TickFrequency = 2;
            this.stars.ValueChanged += new System.EventHandler(this.stars_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // rank
            // 
            this.rank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank.FormattingEnabled = true;
            this.rank.Location = new System.Drawing.Point(6, 52);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(335, 24);
            this.rank.TabIndex = 3;
            this.rank.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // Step4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doingPvp);
            this.Name = "Step4";
            this.Size = new System.Drawing.Size(406, 335);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox doingPvp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar stars;
        private System.Windows.Forms.Label starIndicator;
    }
}
