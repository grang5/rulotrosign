using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace LotroSignatures
{
    public partial class ProgressDialog : Form
    {
        public ProgressDialog(ResourceManager man)
        {
            InitializeComponent();
            label1.Text = man.GetString("extractingImageData");
        }

        public int Value
        {
            get
            {
                return progressBar1.Value;
            }
            set
            {
                progressBar1.Value = value;
                if (value >= 100)
                {
                    this.Visible = false;
                }
            }
        }

        public delegate void setValueDelegate(int value);
        public void SetValue(int value)
        {
            this.Value = value;
        }
    }
}
