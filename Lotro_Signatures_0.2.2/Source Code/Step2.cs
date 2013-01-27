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
    public partial class Step2 : UserControl, IStep
    {
        private ResourceManager man;

        public Step2()
        {
            InitializeComponent();
        }

        public void UpdateLanguage(ResourceManager man)
        {
            this.man = man;
            groupBox1.Text = man.GetString("race");
            groupBox2.Text = man.GetString("class_");
            groupBox3.Text = man.GetString("level");
            int oldIndex = race.SelectedIndex;
            race.Items.Clear();
            race.Items.AddRange(new object[] {
                man.GetString("dwarf"), man.GetString("elf"), man.GetString("hobbit"), man.GetString("man")
            });
            race.SelectedIndexChanged -= race_SelectedIndexChanged;
            race.SelectedIndex = oldIndex;
            race.SelectedIndexChanged += race_SelectedIndexChanged;
        }

        public string Race
        {
            get
            {
                return race.SelectedItem.ToString();
            }
        }

        public string Class
        {
            get
            {
                if (burglar.Checked)
                    return man.GetString("burglar");
                else if (captain.Checked)
                    return man.GetString("captain");
                else if (champion.Checked)
                    return man.GetString("champion");
                else if (guardian.Checked)
                    return man.GetString("guardian");
                else if (hunter.Checked)
                    return man.GetString("hunter");
                else if (loreMaster.Checked)
                    return man.GetString("loremaster");
                else if (runeKeeper.Checked)
                    return man.GetString("runekeeper");
                else if (warden.Checked)
                    return man.GetString("warden");
                else
                    return man.GetString("minstrel");
            }
        }

        public int Level
        {
            get
            {
                return (int)level.Value;
            }
        }

        private void Step2_Load(object sender, EventArgs e)
        {
            level.Value = 75;
        }

        public int ClassId
        {
            get
            {
                if (burglar.Checked)
                {
                    return 0;
                }
                else if (captain.Checked)
                {
                    return 1;
                }
                else if (champion.Checked)
                {
                    return 2;
                }
                else if (guardian.Checked)
                {
                    return 3;
                }
                else if (hunter.Checked)
                {
                    return 4;
                }
                else if (loreMaster.Checked)
                {
                    return 5;
                }
                else if (minstrel.Checked)
                {
                    return 6;
                }
                else if (runeKeeper.Checked)
                {
                    return 7;
                }
                else if (warden.Checked)
                {
                    return 8;
                }
                else
                {
                    return -1;
                }
            }
        }

        #region IStep Member

        public bool OK
        {
            get
            {
                return ClassId >= 0 && race.SelectedIndex >= 0;
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

        private void race_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioButton[] checkBoxes = new RadioButton[] {
                burglar, captain, champion, guardian, hunter, loreMaster, minstrel, runeKeeper, warden
            };
            bool[,] allowedCheckboxes = new bool[,]{
                {false, false, true , true, true, false, true, true , false},
                {false, false, true , true, true, true , true, true , true },
                {true , false, false, true, true, false, true, false, true },
                {true , true , true , true, true, true , true, false, true }
            };
            for (int i = 0; i < allowedCheckboxes.GetLength(1); i++)
            {
                if (allowedCheckboxes[race.SelectedIndex, i])
                {
                    checkBoxes[i].Enabled = true;
                }
                else
                {
                    checkBoxes[i].Enabled = false;
                    checkBoxes[i].Checked = false;
                }
            }
            OKChanged(this, this.OK);
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            OKChanged(this, this.OK);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (level.Value != trackBar1.Value)
            {
                level.Value = trackBar1.Value;
            }
        }

        private void level_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value != level.Value)
            {
                trackBar1.Value = (int)level.Value;
            }
        }
    }
}
