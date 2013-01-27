namespace LotroSignatures
{
    partial class ImportPortraitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportPortraitForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.scale = new System.Windows.Forms.TrackBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imageLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 0;
            // 
            // imageLabel
            // 
            this.imageLabel.Location = new System.Drawing.Point(0, 0);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(0, 0);
            this.imageLabel.TabIndex = 0;
            this.imageLabel.MouseLeave += new System.EventHandler(this.imageLabel_MouseLeave);
            this.imageLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.imageLabel_Paint);
            this.imageLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageLabel_MouseMove);
            this.imageLabel.Click += new System.EventHandler(this.imageLabel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.scaleLabel);
            this.panel2.Controls.Add(this.scale);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.okButton);
            this.panel2.Location = new System.Drawing.Point(806, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 600);
            this.panel2.TabIndex = 1;
            // 
            // scaleLabel
            // 
            this.scaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleLabel.Location = new System.Drawing.Point(3, 9);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(156, 23);
            this.scaleLabel.TabIndex = 7;
            this.scaleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scale
            // 
            this.scale.LargeChange = 10;
            this.scale.Location = new System.Drawing.Point(59, 35);
            this.scale.Maximum = 100;
            this.scale.Name = "scale";
            this.scale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.scale.Size = new System.Drawing.Size(45, 533);
            this.scale.TabIndex = 6;
            this.scale.TickFrequency = 5;
            this.scale.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.scale.Value = 100;
            this.scale.ValueChanged += new System.EventHandler(this.scale_ValueChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(3, 574);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(84, 574);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "jpg";
            this.openFileDialog.Filter = "Screenshots|*.jpg";
            // 
            // ImportPortraitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportPortraitForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.ImportPortraitForm_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImportPortraitForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button cancelButton;
        internal System.Windows.Forms.Button okButton;
        internal System.Windows.Forms.Label scaleLabel;
        internal System.Windows.Forms.TrackBar scale;
        internal System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label imageLabel;
    }
}