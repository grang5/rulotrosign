using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace LotroSignatures
{
    public partial class Step4 : UserControl, IStep
    {
        private string starsString;

        public Step4()
        {
            InitializeComponent();
        }

        public void UpdateLanguage(ResourceManager man)
        {
            doingPvp.Text = man.GetString("doingPvp");
            groupBox1.Text = man.GetString("pvmp");
            label1.Text = man.GetString("pvmpRank");
            label2.Text = man.GetString("stars");

            starsString = man.GetString("stars2");
            stars_ValueChanged(null, null);

            int oldIndex = rank.SelectedIndex;
            rank.Items.Clear();
            for (int i = 0; i <= 15; i++)
            {
                rank.Items.Add(man.GetString(string.Format("rank_{0}", i)));
            }
            rank.SelectedIndexChanged -= rank_SelectedIndexChanged;
            rank.SelectedIndex = oldIndex;
            rank.SelectedIndexChanged += rank_SelectedIndexChanged;
        }

        public Bitmap RankImage
        {
            get
            {
                switch (rank.SelectedIndex)
                {
                    case 0:
                        return null;
                    case 1:
                        return LotroSignatures.Properties.Resources.r1;
                    case 2:
                        return LotroSignatures.Properties.Resources.r2;
                    case 3:
                        return LotroSignatures.Properties.Resources.r3;
                    case 4:
                        return LotroSignatures.Properties.Resources.r4;
                    case 5:
                        return LotroSignatures.Properties.Resources.r5;
                    case 6:
                        return LotroSignatures.Properties.Resources.r6;
                    case 7:
                        return LotroSignatures.Properties.Resources.r7;
                    case 8:
                        return LotroSignatures.Properties.Resources.r8;
                    case 9:
                        return LotroSignatures.Properties.Resources.r9;
                    case 10:
                        return LotroSignatures.Properties.Resources.r10;
                    case 11:
                        return LotroSignatures.Properties.Resources.r11;
                    case 12:
                        return LotroSignatures.Properties.Resources.r12;
                    case 13:
                        return LotroSignatures.Properties.Resources.r13;
                    case 14:
                        return LotroSignatures.Properties.Resources.r14;
                    case 15:
                        return LotroSignatures.Properties.Resources.r15;
                }
                throw new IndexOutOfRangeException();
            }
        }


        public int CountHalfStars
        {
            get
            {
                return stars.Value;
            }
        }

        #region IStep Member

        public bool OK
        {
            get
            {
                return rank.SelectedIndex >= 0;
            }
        }

        public Control Control
        {
            get
            {
                return this;
            }
        }

        public event StepOKChangedHandler OKChanged;

        #endregion

        private void rank_SelectedIndexChanged(object sender, EventArgs e)
        {
            OKChanged(this, this.OK);
        }

        private void doingPvp_CheckedChanged(object sender, EventArgs e)
        {
            if (doingPvp.Checked)
            {
                rank.Enabled = true;
                stars.Enabled = true;
            }
            else
            {
                rank.Enabled = false;
                rank.SelectedIndex = 0;
                stars.Enabled = false;
            }
        }

        private void stars_ValueChanged(object sender, EventArgs e)
        {
            starIndicator.Text = (stars.Value / 2.0) + starsString;
        }
    }
}
