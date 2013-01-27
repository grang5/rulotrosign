namespace LotroSignatures
{
    partial class Step2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.race = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.runeKeeper = new System.Windows.Forms.RadioButton();
            this.warden = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.captain = new System.Windows.Forms.RadioButton();
            this.guardian = new System.Windows.Forms.RadioButton();
            this.hunter = new System.Windows.Forms.RadioButton();
            this.loreMaster = new System.Windows.Forms.RadioButton();
            this.minstrel = new System.Windows.Forms.RadioButton();
            this.champion = new System.Windows.Forms.RadioButton();
            this.burglar = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.level = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // race
            // 
            this.race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.FormattingEnabled = true;
            this.race.Location = new System.Drawing.Point(6, 19);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(376, 24);
            this.race.TabIndex = 0;
            this.race.SelectedIndexChanged += new System.EventHandler(this.race_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.runeKeeper);
            this.groupBox2.Controls.Add(this.warden);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.captain);
            this.groupBox2.Controls.Add(this.guardian);
            this.groupBox2.Controls.Add(this.hunter);
            this.groupBox2.Controls.Add(this.loreMaster);
            this.groupBox2.Controls.Add(this.minstrel);
            this.groupBox2.Controls.Add(this.champion);
            this.groupBox2.Controls.Add(this.burglar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // runeKeeper
            // 
            this.runeKeeper.AutoSize = true;
            this.runeKeeper.Enabled = false;
            this.runeKeeper.Location = new System.Drawing.Point(270, 170);
            this.runeKeeper.Name = "runeKeeper";
            this.runeKeeper.Size = new System.Drawing.Size(14, 13);
            this.runeKeeper.TabIndex = 13;
            this.runeKeeper.TabStop = true;
            this.runeKeeper.UseVisualStyleBackColor = true;
            this.runeKeeper.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // warden
            // 
            this.warden.AutoSize = true;
            this.warden.Enabled = false;
            this.warden.Location = new System.Drawing.Point(352, 170);
            this.warden.Name = "warden";
            this.warden.Size = new System.Drawing.Size(14, 13);
            this.warden.TabIndex = 14;
            this.warden.TabStop = true;
            this.warden.UseVisualStyleBackColor = true;
            this.warden.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // label8
            // 
            this.label8.Image = global::LotroSignatures.Properties.Resources.Rune_keeper_icon;
            this.label8.Location = new System.Drawing.Point(249, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 54);
            this.label8.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Image = global::LotroSignatures.Properties.Resources.Warden_icon;
            this.label9.Location = new System.Drawing.Point(331, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 54);
            this.label9.TabIndex = 14;
            // 
            // captain
            // 
            this.captain.AutoSize = true;
            this.captain.Enabled = false;
            this.captain.Location = new System.Drawing.Point(145, 78);
            this.captain.Name = "captain";
            this.captain.Size = new System.Drawing.Size(14, 13);
            this.captain.TabIndex = 7;
            this.captain.TabStop = true;
            this.captain.UseVisualStyleBackColor = true;
            this.captain.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // guardian
            // 
            this.guardian.AccessibleName = "";
            this.guardian.AutoSize = true;
            this.guardian.Enabled = false;
            this.guardian.Location = new System.Drawing.Point(320, 78);
            this.guardian.Name = "guardian";
            this.guardian.Size = new System.Drawing.Size(14, 13);
            this.guardian.TabIndex = 9;
            this.guardian.TabStop = true;
            this.guardian.UseVisualStyleBackColor = true;
            this.guardian.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // hunter
            // 
            this.hunter.AutoSize = true;
            this.hunter.Enabled = false;
            this.hunter.Location = new System.Drawing.Point(26, 170);
            this.hunter.Name = "hunter";
            this.hunter.Size = new System.Drawing.Size(14, 13);
            this.hunter.TabIndex = 10;
            this.hunter.TabStop = true;
            this.hunter.UseVisualStyleBackColor = true;
            this.hunter.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // loreMaster
            // 
            this.loreMaster.AutoSize = true;
            this.loreMaster.Enabled = false;
            this.loreMaster.Location = new System.Drawing.Point(108, 170);
            this.loreMaster.Name = "loreMaster";
            this.loreMaster.Size = new System.Drawing.Size(14, 13);
            this.loreMaster.TabIndex = 11;
            this.loreMaster.TabStop = true;
            this.loreMaster.UseVisualStyleBackColor = true;
            this.loreMaster.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // minstrel
            // 
            this.minstrel.AutoSize = true;
            this.minstrel.Enabled = false;
            this.minstrel.Location = new System.Drawing.Point(188, 170);
            this.minstrel.Name = "minstrel";
            this.minstrel.Size = new System.Drawing.Size(14, 13);
            this.minstrel.TabIndex = 12;
            this.minstrel.TabStop = true;
            this.minstrel.UseVisualStyleBackColor = true;
            this.minstrel.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // champion
            // 
            this.champion.AutoSize = true;
            this.champion.Enabled = false;
            this.champion.Location = new System.Drawing.Point(232, 78);
            this.champion.Name = "champion";
            this.champion.Size = new System.Drawing.Size(14, 13);
            this.champion.TabIndex = 8;
            this.champion.TabStop = true;
            this.champion.UseVisualStyleBackColor = true;
            this.champion.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // burglar
            // 
            this.burglar.AutoSize = true;
            this.burglar.Enabled = false;
            this.burglar.Location = new System.Drawing.Point(57, 78);
            this.burglar.Name = "burglar";
            this.burglar.Size = new System.Drawing.Size(14, 13);
            this.burglar.TabIndex = 6;
            this.burglar.TabStop = true;
            this.burglar.UseVisualStyleBackColor = true;
            this.burglar.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(124, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 54);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(87, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 54);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(211, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 54);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(299, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 54);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 54);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(167, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 54);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 54);
            this.label1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.level);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Location = new System.Drawing.Point(9, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(319, 21);
            this.level.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(63, 20);
            this.level.TabIndex = 1;
            this.level.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.level.ValueChanged += new System.EventHandler(this.level_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Maximum = 65;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(307, 25);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 65;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Step2";
            this.Size = new System.Drawing.Size(406, 335);
            this.Load += new System.EventHandler(this.Step2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox race;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown level;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton captain;
        private System.Windows.Forms.RadioButton guardian;
        private System.Windows.Forms.RadioButton hunter;
        private System.Windows.Forms.RadioButton loreMaster;
        private System.Windows.Forms.RadioButton minstrel;
        private System.Windows.Forms.RadioButton champion;
        private System.Windows.Forms.RadioButton burglar;
        private System.Windows.Forms.RadioButton runeKeeper;
        private System.Windows.Forms.RadioButton warden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

    }
}
