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
    public partial class Step3 : UserControl, IStep
    {
        ResourceManager man;

        public Step3()
        {
            InitializeComponent();
        }

        public void UpdateLanguage(ResourceManager man)
        {
            this.man = man;
            noKin.Text = man.GetString("noKinship");
            label1.Text = man.GetString("kinName");
            label2.Text = man.GetString("kinType");
            label3.Text = man.GetString("kinRank");

            int oldIndex = kinType.SelectedIndex;
            kinType.Items.Clear();
            kinType.Items.AddRange(new object[] {
                man.GetString("mixed"), man.GetString("dwarf"), man.GetString("elf"), man.GetString("hobbit"), man.GetString("man")
            });
            kinType.SelectedIndexChanged -= kinType_SelectedIndexChanged;
            kinType.SelectedIndex = oldIndex;
            kinType.SelectedIndexChanged += kinType_SelectedIndexChanged;
        }

        public bool NoKinship
        {
            get
            {
                return noKin.Checked;
            }
        }

        public string KinRank
        {
            get
            {
                return kinRank.SelectedItem.ToString();
            }
        }

        public string KinName
        {
            get
            {
                return kinName.Text;
            }
        }

        private void Step3_Load(object sender, EventArgs e)
        {
            kinType.SelectedIndex = 0;
        }

        #region IStep Member

        public bool OK
        {
            get
            {
                return NoKinship || (kinName.Text.Length > 0 && kinRank.SelectedIndex >= 0);
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

        private void kinName_TextChanged(object sender, EventArgs e)
        {
            OKChanged(this, this.OK);
        }

        private void kinType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = kinRank.SelectedIndex;
            kinRank.Items.Clear();

            switch (kinType.SelectedIndex)
            {
                case 0:
                    kinRank.Items.AddRange(new object[] {
                        man.GetString("recruit_mixed"), man.GetString("member_mixed"), man.GetString("officer_mixed"),
                        man.GetString("founder_mixed"), man.GetString("leader_mixed") });
                    break;
                case 1:
                    kinRank.Items.AddRange(new object[] {
                        man.GetString("recruit_dwarf"), man.GetString("member_dwarf"), man.GetString("officer_dwarf"),
                        man.GetString("founder_dwarf"), man.GetString("leader_dwarf") });
                    break;
                case 2:
                    kinRank.Items.AddRange(new object[] {
                        man.GetString("recruit_elf"), man.GetString("member_elf"), man.GetString("officer_elf"),
                        man.GetString("founder_elf"), man.GetString("leader_elf") });
                    break;
                case 3:
                    kinRank.Items.AddRange(new object[] {
                        man.GetString("recruit_hobbit"), man.GetString("member_hobbit"), man.GetString("officer_hobbit"),
                        man.GetString("founder_hobbit"), man.GetString("leader_hobbit") });
                    break;
                case 4:
                    kinRank.Items.AddRange(new object[] {
                        man.GetString("recruit_man"), man.GetString("member_man"), man.GetString("officer_man"),
                        man.GetString("founder_man"), man.GetString("leader_man") });
                    break;
            }
            kinRank.SelectedIndex = selected;
        }

        private void kinRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            OKChanged(this, this.OK);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            kinName.Enabled = !noKin.Checked;
            kinType.Enabled = !noKin.Checked;
            kinRank.Enabled = !noKin.Checked;
            OKChanged(this, this.OK);
        }
    }
}
