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
    public partial class Step5 : UserControl, IStep
    {
        ResourceManager man;

        public Step5()
        {
            InitializeComponent();
            vocation.SelectedIndexChanged += combobox_SelectedIndexChanged;
        }

        public void UpdateLanguage(ResourceManager man)
        {
            this.man = man;
            label1.Text = man.GetString("vocation");
            label2.Text = man.GetString("professions");
            label3.Text = label6.Text = label8.Text = man.GetString("tier");
            label4.Text = label5.Text = label7.Text = man.GetString("masteryTier");

            int oldIndex = vocation.SelectedIndex;
            vocation.Items.Clear();
            vocation.Items.AddRange(new object[] {
                man.GetString("noProfession"),
                man.GetString("armourer"),
                man.GetString("armsman"),
                man.GetString("explorer"),
                man.GetString("historian"),
                man.GetString("tinker"),
                man.GetString("woodsman"),
                man.GetString("yeoman")
            });
            vocation.SelectedIndexChanged -= combobox_SelectedIndexChanged;
            vocation.SelectedIndex = oldIndex;
            vocation.SelectedIndexChanged += combobox_SelectedIndexChanged;

            foreach (ComboBox profNTier in new object[] { prof1tier, prof2tier, prof3tier })
            {
                oldIndex = profNTier.SelectedIndex;
                profNTier.Items.Clear();
                profNTier.Items.AddRange(new object[] {
                    man.GetString("tier0"),
                    man.GetString("tier1"),
                    man.GetString("tier2"),
                    man.GetString("tier3"),
                    man.GetString("tier4"),
                    man.GetString("tier5"),
                    man.GetString("tier6"),
                    man.GetString("tier7")
                });
                profNTier.SelectedIndexChanged -= combobox_SelectedIndexChanged;
                profNTier.SelectedIndex = oldIndex;
                profNTier.SelectedIndexChanged += combobox_SelectedIndexChanged;
            }

            foreach (ComboBox profNMastery in new object[] { prof1mastery, prof2mastery, prof3mastery })
            {
                oldIndex = profNMastery.SelectedIndex;
                profNMastery.Items.Clear();
                profNMastery.Items.AddRange(new object[] {
                    man.GetString("masterTier0"),
                    man.GetString("masterTier1"),
                    man.GetString("masterTier2"),
                    man.GetString("masterTier3"),
                    man.GetString("masterTier4"),
                    man.GetString("masterTier5"),
                    man.GetString("masterTier6"),
                    man.GetString("masterTier7")
                });
                profNMastery.SelectedIndexChanged -= combobox_SelectedIndexChanged;
                profNMastery.SelectedIndex = oldIndex;
                profNMastery.SelectedIndexChanged += combobox_SelectedIndexChanged;
            }
        }

        public bool HasVocation
        {
            get
            {
                return vocation.SelectedIndex > 0;
            }
        }

        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 1:
                        return prof1box.Text;
                    case 2:
                        return prof2box.Text;
                    case 3:
                        return prof3box.Text;
                }
                throw new IndexOutOfRangeException();
            }
        }

        public int getProfessionProgress(int num)
        {
            switch (num)
            {
                case 1:
                    return prof1tier.SelectedIndex;
                case 2:
                    return prof2tier.SelectedIndex;
                case 3:
                    return prof3tier.SelectedIndex;
            }
            throw new IndexOutOfRangeException();
        }

        public int getProfessionMasteryProgress(int num)
        {
            switch (num)
            {
                case 1:
                    return prof1mastery.SelectedIndex;
                case 2:
                    return prof2mastery.SelectedIndex;
                case 3:
                    return prof3mastery.SelectedIndex;
            }
            throw new IndexOutOfRangeException();
        }

        private void vocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vocation.SelectedIndex == 0)
            {
                prof1box.Text = "";
                prof2box.Text = "";
                prof3box.Text = "";

                prof1tier.Enabled = false;
                prof2tier.Enabled = false;
                prof3tier.Enabled = false;

                prof1mastery.Enabled = false;
                prof2mastery.Enabled = false;
                prof3mastery.Enabled = false;
            }
            else
            {
                prof1tier.Enabled = true;
                prof2tier.Enabled = true;
                prof3tier.Enabled = true;

                prof1mastery.Enabled = true;
                prof2mastery.Enabled = true;
                prof3mastery.Enabled = true;

                #region switch
                switch (vocation.SelectedIndex)
                {
                    case 1:
                        prof1box.Text = man.GetString("prospector");
                        prof2box.Text = man.GetString("metalsmith");
                        prof3box.Text = man.GetString("tailor");
                        break;
                    case 2:
                        prof1box.Text = man.GetString("weaponsmith");
                        prof2box.Text = man.GetString("woodworker");
                        prof3box.Text = man.GetString("prospector");
                        break;
                    case 3:
                        prof1box.Text = man.GetString("tailor");
                        prof2box.Text = man.GetString("forester");
                        prof3box.Text = man.GetString("prospector");
                        break;
                    case 4:
                        prof1box.Text = man.GetString("scholar");
                        prof2box.Text = man.GetString("farmer");
                        prof3box.Text = man.GetString("weaponsmith");
                        break;
                    case 5:
                        prof1box.Text = man.GetString("jeweller");
                        prof2box.Text = man.GetString("prospector");
                        prof3box.Text = man.GetString("cook");
                        break;
                    case 6:
                        prof1box.Text = man.GetString("woodworker");
                        prof2box.Text = man.GetString("forester");
                        prof3box.Text = man.GetString("farmer");
                        break;
                    case 7:
                        prof1box.Text = man.GetString("cook");
                        prof2box.Text = man.GetString("farmer");
                        prof3box.Text = man.GetString("tailor");
                        break;
                }
                #endregion
            }
        }

        #region IStep Member

        public bool OK
        {
            get
            {
                return (vocation.SelectedIndex >= 0 &&
                    (vocation.SelectedIndex == 0 ||
                    (prof1tier.SelectedIndex >= 0 && prof1mastery.SelectedIndex >= 0 &&
                    prof2tier.SelectedIndex >= 0 && prof2mastery.SelectedIndex >= 0 &&
                    prof3tier.SelectedIndex >= 0 && prof3mastery.SelectedIndex >= 0)));
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

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OKChanged(this, this.OK);
        }
    }
}
