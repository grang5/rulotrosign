namespace LotroSignatures
{
    partial class Step6
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
            this.importButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.useDefault = new System.Windows.Forms.RadioButton();
            this.useRing = new System.Windows.Forms.RadioButton();
            this.useImported = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // importButton
            // 
            this.importButton.Enabled = false;
            this.importButton.Location = new System.Drawing.Point(94, 101);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(219, 23);
            this.importButton.TabIndex = 1;
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(133, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 141);
            this.label1.TabIndex = 2;
            // 
            // useDefault
            // 
            this.useDefault.AutoSize = true;
            this.useDefault.Location = new System.Drawing.Point(31, 44);
            this.useDefault.Name = "useDefault";
            this.useDefault.Size = new System.Drawing.Size(14, 13);
            this.useDefault.TabIndex = 3;
            this.useDefault.TabStop = true;
            this.useDefault.UseVisualStyleBackColor = true;
            this.useDefault.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // useRing
            // 
            this.useRing.AutoSize = true;
            this.useRing.Location = new System.Drawing.Point(31, 63);
            this.useRing.Name = "useRing";
            this.useRing.Size = new System.Drawing.Size(14, 13);
            this.useRing.TabIndex = 4;
            this.useRing.TabStop = true;
            this.useRing.UseVisualStyleBackColor = true;
            this.useRing.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // useImported
            // 
            this.useImported.AutoSize = true;
            this.useImported.Location = new System.Drawing.Point(31, 82);
            this.useImported.Name = "useImported";
            this.useImported.Size = new System.Drawing.Size(14, 13);
            this.useImported.TabIndex = 5;
            this.useImported.TabStop = true;
            this.useImported.UseVisualStyleBackColor = true;
            this.useImported.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Step6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.useImported);
            this.Controls.Add(this.useRing);
            this.Controls.Add(this.useDefault);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importButton);
            this.Name = "Step6";
            this.Size = new System.Drawing.Size(406, 335);
            this.EnabledChanged += new System.EventHandler(this.Step6_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton useDefault;
        private System.Windows.Forms.RadioButton useRing;
        private System.Windows.Forms.RadioButton useImported;
    }
}
