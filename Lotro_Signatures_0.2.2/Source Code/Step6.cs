using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LotroSignatures
{
    public partial class Step6 : UserControl, IStep
    {
        bool invoked = false;
        Image portrait = null;
        Image lastImportedImage = null;
        ImportPortraitForm form = new ImportPortraitForm();

        public Step6()
        {
            InitializeComponent();
        }

        #region IStep Member

        public bool OK
        {
            get
            {
                return invoked && !(useImported.Checked && portrait == null);
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

        void IStep.UpdateLanguage(System.Resources.ResourceManager man)
        {
            useDefault.Text = man.GetString("useDefault");
            useRing.Text = man.GetString("useRingSymbol");
            useImported.Text = man.GetString("useImportedPortrait");
            importButton.Text = form.Text = form.openFileDialog.Title = man.GetString("import");
            form.cancelButton.Text = man.GetString("cancel");
            form.okButton.Text = man.GetString("ok");
            form.scaleLabel.Text = man.GetString("scale");
            form.manager = man;
        }

        #endregion

        private void Step6_EnabledChanged(object sender, EventArgs e)
        {
            invoked |= this.Enabled;
            if (OKChanged != null)
            {
                OKChanged(this, this.OK);
            }
        }

        public bool CustomPortraitEnabled
        {
            get
            {
                return useImported.Checked;
            }
        }

        public bool OneRingEnabled
        {
            get
            {
                return useRing.Checked;
            }
        }

        public Image Portrait
        {
            get
            {
                return portrait;
            }
            private set
            {
                portrait = value;
                label1.Image = value;
                if (OKChanged != null)
                {
                    OKChanged(this, this.OK);
                }
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            form.PortraitSelected += form_PortraitSelected;
            form.ShowDialog(this.ParentForm);
            form.PortraitSelected -= form_PortraitSelected;
        }

        void form_PortraitSelected(Image portrait)
        {
            Portrait = portrait;
            lastImportedImage = portrait;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (useImported.Checked)
            {
                importButton.Enabled = true;
                Portrait = lastImportedImage;
            }
            else if (useRing.Checked)
            {
                importButton.Enabled = false;
                Portrait = LotroSignatures.Properties.Resources.ring;
            }
            else
            {
                importButton.Enabled = false;
                Portrait = null;
            }
            if (OKChanged != null)
            {
                OKChanged(this, this.OK);
            }
        }
    }
}
