namespace LotroSignatures
{
    partial class Step1
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
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.ComboBox();
            this.femaleBox = new System.Windows.Forms.RadioButton();
            this.maleBox = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(27, 98);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(337, 23);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // server
            // 
            this.server.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.server.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.server.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server.Items.AddRange(new object[] {
            "Belegaer",
            "Eldar",
            "Estel",
            "Evernight",
            "Gilrain",
            "Laurelin",
            "Maiar",
            "Morthond",
            "Sirannon",
            "Snowbourn",
            "Vanyar",
            "Форност",
            "Мирквуд",
            "Агларонд"});
            this.server.Location = new System.Drawing.Point(27, 190);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(337, 24);
            this.server.TabIndex = 3;
            this.server.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // femaleBox
            // 
            this.femaleBox.AutoSize = true;
            this.femaleBox.Location = new System.Drawing.Point(305, 127);
            this.femaleBox.Name = "femaleBox";
            this.femaleBox.Size = new System.Drawing.Size(14, 13);
            this.femaleBox.TabIndex = 4;
            this.femaleBox.UseVisualStyleBackColor = true;
            // 
            // maleBox
            // 
            this.maleBox.AutoSize = true;
            this.maleBox.Checked = true;
            this.maleBox.Location = new System.Drawing.Point(229, 127);
            this.maleBox.Name = "maleBox";
            this.maleBox.Size = new System.Drawing.Size(14, 13);
            this.maleBox.TabIndex = 5;
            this.maleBox.TabStop = true;
            this.maleBox.UseVisualStyleBackColor = true;
            // 
            // Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maleBox);
            this.Controls.Add(this.femaleBox);
            this.Controls.Add(this.server);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Step1";
            this.Size = new System.Drawing.Size(406, 335);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox server;
        private System.Windows.Forms.RadioButton femaleBox;
        private System.Windows.Forms.RadioButton maleBox;
    }
}
