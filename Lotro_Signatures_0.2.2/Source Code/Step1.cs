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
    public partial class Step1 : UserControl, IStep
    {
        public Step1()
        {
            InitializeComponent();
        }

        public void UpdateLanguage(ResourceManager man)
        {
            label1.Text = man.GetString("name");
            maleBox.Text = man.GetString("male");
            femaleBox.Text = man.GetString("female");
            label2.Text = man.GetString("server");
        }

        public string PlayerName
        {
            get
            {
                return name.Text;
            }
        }

        public bool Female
        {
            get
            {
                return femaleBox.Checked;
            }
        }

        public string Server
        {
            get
            {
                return server.Text;
            }
        }

        #region IStep Member

        public bool OK
        {
            get {
                return name.Text.Length > 0 && server.Text.Length > 0;
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

        private new void TextChanged(object sender, EventArgs e)
        {
            if (OKChanged != null)
            {
                OKChanged(this, this.OK);
            }
        }
    }
}
