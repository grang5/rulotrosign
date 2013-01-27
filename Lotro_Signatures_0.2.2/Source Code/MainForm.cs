using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.IO;
using System.Resources;
using System.Globalization;
using System.Threading;

/**
 * Lotro Signature Creator - Creates signature images for the MMORPG "Lord of the Rings Online"
 *
 * Copyright (C) 2009 Paul Menczel
 *
 * This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License along with this program; if not, see <http://www.gnu.org/licenses/>.
 * 
 * Contact: illuvatar@byte-welt.de
 */

namespace LotroSignatures
{
    public partial class MainForm : Form
    {
        private ResourceManager resourceManager = 
            new ResourceManager("LotroSignatures.Strings",
                System.Reflection.Assembly.GetExecutingAssembly());
        private CultureInfo englishCulture = new CultureInfo("en-GB");
        private CultureInfo germanCulture = new CultureInfo("de-DE");
        private CultureInfo frenchCulture = new CultureInfo("fr-FR");
        private CultureInfo russianCulture = new CultureInfo("ru-RU");

        FontFamily family;
        int step = 0;
        Label[] stepCheckBoxes;
        Label[] stepDescriptions;
        IStep[] steps;

        public MainForm()
        {
            InitializeComponent();
        }
        private void UpdateLanguage()
        {
            label1.Text = resourceManager.GetString("step");
            label2.Text = (step + 1) + resourceManager.GetString("of7");
            label9.Text = resourceManager.GetString("enterNameServer");
            label10.Text = resourceManager.GetString("chooseRaceClass");
            label11.Text = resourceManager.GetString("kinshipDetails");
            label12.Text = resourceManager.GetString("selectPvmp");
            label14.Text = resourceManager.GetString("craftingProgress");
            label13.Text = resourceManager.GetString("importPortrait");
            label16.Text = resourceManager.GetString("finished");
            backButton.Text = resourceManager.GetString("back");
            nextButton.Text = resourceManager.GetString("next");

            bool allStepsOK = steps != null;
            if (steps != null)
            {
                foreach (IStep s in steps)
                {
                    allStepsOK &= s.OK;
                    s.UpdateLanguage(resourceManager);
                }
            }
            if (allStepsOK)
            {
                cancelButton.Text = resourceManager.GetString("exit");
            }
            else
            {
                cancelButton.Text = resourceManager.GetString("cancel");
            }

            Refresh();
        }

        private static readonly Point[] starPoints;
        static MainForm()
        {
            starPoints = new Point[5]{
              new Point(190, 125), new Point(190, 114), new Point(205, 106), new Point(220, 114), new Point(220, 125)
            };
        }
        Font font10, font12, font16, font18, font25;
        Font arial10 = new Font(FontFamily.GenericSansSerif, 10);
        Font arial20 = new Font(FontFamily.GenericSansSerif, 20);
        Brush whiteBrush = new SolidBrush(Color.White);
        Brush yellowBrush = new SolidBrush(Color.Yellow);
        Brush blackBrush = new SolidBrush(Color.Black);
        public Bitmap CreateImage()
        {
            Step2 step2 = (Step2)steps[1];
            Step3 step3 = (Step3)steps[2];
            Step4 step4 = (Step4)steps[3];
            Step5 step5 = (Step5)steps[4];
            Step6 step6 = (Step6)steps[5];

            Bitmap baseImage;
            if (step2.Race == resourceManager.GetString("man") && !step1.Female)
            {
                baseImage = (Bitmap)LotroSignatures.Properties.Resources.male_man.Clone();
            }
            else if (step2.Race == resourceManager.GetString("man") && step1.Female)
            {
                baseImage = (Bitmap)LotroSignatures.Properties.Resources.female_man.Clone();
            }
            else if (step2.Race == resourceManager.GetString("elf") && !step1.Female)
            {
                baseImage = (Bitmap)LotroSignatures.Properties.Resources.male_elf.Clone();
            }
            else if (step2.Race == resourceManager.GetString("elf") && step1.Female)
            {
                baseImage = (Bitmap)LotroSignatures.Properties.Resources.female_elf.Clone();
            }
            else if (step2.Race == resourceManager.GetString("hobbit") && !step1.Female)
            {
                baseImage = (Bitmap)LotroSignatures.Properties.Resources.male_hobbit.Clone();
            }
            else if (step2.Race == resourceManager.GetString("hobbit") && step1.Female)
            {
                baseImage = (Bitmap)LotroSignatures.Properties.Resources.female_hobbit.Clone();
            }
            else
            {
                baseImage = (Bitmap)LotroSignatures.Properties.Resources.dwarf.Clone();
            }
            Graphics g = Graphics.FromImage(baseImage);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            // class symbol
            Bitmap classSymbol;
            # region find class symbol
            switch (step2.ClassId)
            {
                case 0:
                    classSymbol = LotroSignatures.Properties.Resources.Burglar_icon;
                    break;
                case 1:
                    classSymbol = LotroSignatures.Properties.Resources.Captain_icon;
                    break;
                case 2:
                    classSymbol = LotroSignatures.Properties.Resources.Champion_icon;
                    break;
                case 3:
                    classSymbol = LotroSignatures.Properties.Resources.Guardian_icon;
                    break;
                case 4:
                    classSymbol = LotroSignatures.Properties.Resources.Hunter_icon;
                    break;
                case 5:
                    classSymbol = LotroSignatures.Properties.Resources.Lore_master_icon;
                    break;
                case 7:
                    classSymbol = LotroSignatures.Properties.Resources.Rune_keeper_icon;
                    break;
                case 8:
                    classSymbol = LotroSignatures.Properties.Resources.Warden_icon;
                    break;
                default:
                    classSymbol = LotroSignatures.Properties.Resources.Minstrel_icon;
                    break;
            }
            #endregion
            g.DrawImage(classSymbol, 118, 53);
            // name
            DrawStringWithOutline(g, step1.PlayerName, font18, blackBrush, whiteBrush, 140, 3);
            // server
            DrawStringWithOutline(g, resourceManager.GetString("of") + step1.Server, font16, blackBrush, whiteBrush, 140, 20);
            // level
            g.DrawString(step2.Level.ToString(), arial20, yellowBrush, 0, 0);
            // race
            g.DrawString(step2.Race, font16, whiteBrush, 180, 51);
            // class
            g.DrawString(step2.Class, font16, whiteBrush, 180, 69);
            // kin
            if (!step3.NoKinship)
            {
                g.DrawString(step3.KinRank + resourceManager.GetString("of2") + step3.KinName, font12, whiteBrush, 180, 89);
            }
            // rank
            if (step4.RankImage != null)
            {
                g.DrawImage(step4.RankImage, 200, 117, 19, 19);
            }
            // stars
            for (int halfStars = 1; halfStars < step4.CountHalfStars; halfStars += 2)
            {
                g.DrawImage(LotroSignatures.Properties.Resources.star, starPoints[halfStars / 2]);
            }
            if (step4.CountHalfStars % 2 == 1)
            {
                g.DrawImage(LotroSignatures.Properties.Resources.half_star, starPoints[step4.CountHalfStars / 2]);
            }
            if (step5.HasVocation)
            {
                // profession 1
                g.DrawString(step5[1], arial10, blackBrush, 275 - g.MeasureString(step5[1], arial10).Width / 2, 107);
                DrawStringWithOutline(g, step5.getProfessionProgress(1).ToString(), arial10, blackBrush, whiteBrush, 253, 120);
                DrawStringWithOutline(g, step5.getProfessionMasteryProgress(1).ToString(), arial10, blackBrush, whiteBrush, 283, 120);
                // profession 2
                g.DrawString(step5[2], arial10, blackBrush, 348 - g.MeasureString(step5[2], arial10).Width / 2, 107);
                DrawStringWithOutline(g, step5.getProfessionProgress(2).ToString(), arial10, blackBrush, whiteBrush, 326, 120);
                DrawStringWithOutline(g, step5.getProfessionMasteryProgress(2).ToString(), arial10, blackBrush, whiteBrush, 356, 120);
                // profession 3
                g.DrawString(step5[3], arial10, blackBrush, 424 - g.MeasureString(step5[3], arial10).Width / 2, 107);
                DrawStringWithOutline(g, step5.getProfessionProgress(3).ToString(), arial10, blackBrush, whiteBrush, 403, 120);
                DrawStringWithOutline(g, step5.getProfessionMasteryProgress(3).ToString(), arial10, blackBrush, whiteBrush, 432, 120);
            }

            if (step6.CustomPortraitEnabled)
            {
                g.DrawImage(step6.Portrait, 0, 0, 141, 141);
            }
            else if (step6.OneRingEnabled)
            {
                g.DrawImage(LotroSignatures.Properties.Resources.ring, 0, 0, 141, 141);
            }

            g.Dispose();
            return baseImage;
        }

        private void DrawStringWithOutline(Graphics g, string str, Font font, Brush outline, Brush foreground, int x, int y)
        {
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    g.DrawString(str, font, outline, i, j);
                }
            }
            g.DrawString(str, font, foreground, x + 1, y + 1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Resources\Font_Regular.ttf");
            pfc.AddFontFile(@"Resources\Font_Bold.ttf");
            /*byte[] fontdata = LotroSignatures.Properties.Resources.TrajanPro_Regular;
            IntPtr data = Marshal.AllocCoTaskMem(fontdata.Length);
            Marshal.Copy(fontdata, 0, data, fontdata.Length);
            pfc.AddMemoryFont(data, fontdata.Length);*/
            //Marshal.FreeCoTaskMem(data);
            family = (FontFamily)pfc.Families.GetValue(0);
            font10 = new Font(family, 10, FontStyle.Bold);
            font12 = new Font(family, 12, FontStyle.Bold);
            font16 = new Font(family, 16, FontStyle.Bold);
            font18 = new Font(family, 18, FontStyle.Bold);
            font25 = new Font(family, 25, FontStyle.Bold);

            stepCheckBoxes = new Label[] { label3, label8, label7, label6, label5, label4, label17 };
            stepDescriptions = new Label[] { label9, label10, label11, label12, label14, label13, label16 };
            steps = new IStep[] { step1, new Step2(), new Step3(), new Step4(), new Step5(), new Step6(), new Step7(this) };

            foreach (IStep step in steps)
            {
                step.Control.Enabled = false;
                step.OKChanged += step_OKChanged;
            }
            step1.Enabled = true;
            UpdateLanguage();
        }

        private void step_OKChanged(IStep source, bool ok)
        {
            int indexOfSource = -1;
            for (int i = 0; i < steps.Length; i++)
            {
                if (steps[i] == source)
                {
                    indexOfSource = i;
                }
            }

            if (ok)
            {
                stepCheckBoxes[indexOfSource].Image = LotroSignatures.Properties.Resources.success;
            }
            else
            {
                stepCheckBoxes[indexOfSource].Image = LotroSignatures.Properties.Resources.fail;
            }

            if (indexOfSource == step)
            {
                nextButton.Enabled = ok && (step < steps.Length - 1);
            }
            RedoDescLabelCursors();
            UpdateLanguage(); // changes button description to "exit" if necessary
        }

        private void RedoDescLabelCursors()
        {
            bool allPreviousOK = true;
            for (int i = 0; i < stepDescriptions.Length; i++)
            {
                if (allPreviousOK && i != step)
                {
                    stepDescriptions[i].Cursor = Cursors.Hand;
                }
                else
                {
                    stepDescriptions[i].Cursor = Cursors.Default;
                }

                if (!steps[i].OK)
                {
                    allPreviousOK = false;
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (step >= steps.Length - 1) return;
            if (!steps[step].OK) return;
            step++;
            StepChanged();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (step <= 0) return;
            step--;
            StepChanged();
        }

        private void StepChanged()
        {
            foreach (Control c in content.Controls)
            {
                c.Enabled = false;
            }
            content.Controls.Clear();
            content.Controls.Add(steps[step].Control);
            steps[step].Control.Enabled = true;
            backButton.Enabled = step > 0;
            nextButton.Enabled = (step < steps.Length - 1) && steps[step].OK;

            for (int i = 0; i < stepDescriptions.Length; i++)
            {
                if (i == step)
                {
                    stepDescriptions[i].Font = new Font(stepDescriptions[i].Font, FontStyle.Bold);
                }
                else
                {
                    stepDescriptions[i].Font = new Font(stepDescriptions[i].Font, FontStyle.Regular);
                }
            }
            UpdateLanguage(); // updates the "step n of 7"
            RedoDescLabelCursors();
        }

        void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Lotro Signatures", font25, new SolidBrush(Color.Black), 20, 4, StringFormat.GenericTypographic);
            e.Graphics.DrawString(resourceManager.GetString("about"), font10, new SolidBrush(Color.Black), 140, 36, StringFormat.GenericTypographic);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            bool allStepsOK = true;
            foreach (IStep step in steps)
            {
                allStepsOK &= step.OK;
            }
            if (allStepsOK || 
                    DialogResult.Yes == MessageBox.Show(
                        this,
                        resourceManager.GetString("reallyCancel"),
                        "Lotro Signatures",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)) {
                Application.Exit();
            }
        }

        private void descLabel_Click(object sender, EventArgs e)
        {
            int indexOfClickedLabel = -1;
            for (int i = 0; i < stepDescriptions.Length; i++)
            {
                if (stepDescriptions[i] == sender)
                {
                    indexOfClickedLabel = i;
                }
            }
            if (indexOfClickedLabel < 0)
            {
                return;
            }
            if (indexOfClickedLabel == step)
            {
                return;
            }

            bool jumpOk = true;
            for (int i = 0; i < indexOfClickedLabel; i++)
            {
                jumpOk &= steps[i].OK;
            }
            if (jumpOk)
            {
                step = indexOfClickedLabel;
                StepChanged();
            }
        }

        private void englishFlag_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = englishCulture;
            UpdateLanguage();
        }

        private void germanFlag_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = germanCulture;
            UpdateLanguage();
        }

        private void frenchFlag_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = frenchCulture;
            UpdateLanguage();
        }

        private void russianFlag_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = russianCulture;
            UpdateLanguage();
        }
    }
}
