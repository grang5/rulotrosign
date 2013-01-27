using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Drawing.Imaging;

namespace LotroSignatures
{
    public partial class Step7 : UserControl, IStep
    {
        private bool saved = false;
        private MainForm mainForm;
        private Bitmap signature;

        public Step7(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public void UpdateLanguage(ResourceManager man)
        {
            label2.Text = man.GetString("success");
            button1.Text = man.GetString("copy2clipboard");
            button2.Text = man.GetString("save2file");
            label3.Text = man.GetString("smallPreview");
            label1.Text = man.GetString("finalText");
        }

        private bool Saved
        {
            get
            {
                return saved;
            }
            set
            {
                saved = value;
                OKChanged(this, value);
            }
        }

        #region IStep Member

        public bool OK
        {
            get
            {
                return Saved;
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

        private void Step6_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                signature = mainForm.CreateImage();
                Bitmap preview = new Bitmap(245, 75);
                Graphics g = Graphics.FromImage(preview);
                g.DrawImage(signature, 0, 0, 245, 75);
                g.Dispose();
                imageOutput.Image = preview;
                imageOutput.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog(mainForm);
            if (dr == DialogResult.OK)
            {
                System.IO.Stream stream = saveFileDialog1.OpenFile();

                ImageFormat format;
                if (saveFileDialog1.FileName.EndsWith("jpg"))
                    format = ImageFormat.Jpeg;
                else if (saveFileDialog1.FileName.EndsWith("gif"))
                    format = ImageFormat.Gif;
                else
                    format = ImageFormat.Png;

                signature.Save(stream, format);
                stream.Close();
                Saved = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tempFilePath = System.IO.Path.GetTempPath() + "Signature.png";
            signature.Save(tempFilePath);
            DataObject data = new DataObject();
            data.SetData(DataFormats.Bitmap, signature);
            data.SetData(DataFormats.FileDrop, new String[] { tempFilePath });
            Clipboard.SetDataObject(data);
            Saved = true;
        }
    }
}
