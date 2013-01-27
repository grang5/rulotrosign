using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Threading;

namespace LotroSignatures
{
    public partial class ImportPortraitForm : Form
    {
        private static readonly Point NULL_POINT = new Point(-1, -1);
        Image currentImage;
        Point mousePosition = NULL_POINT;
        Point selection = NULL_POINT;
        internal ResourceManager manager;

        public ImportPortraitForm()
        {
            InitializeComponent();
        }

        private void ImportPortraitForm_Shown(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    currentImage = Image.FromFile(openFileDialog.FileName);
                    if (currentImage.Size.Width < 141 || currentImage.Size.Height < 141)
                    {
                        MessageBox.Show(this, manager.GetString("imageTooSmall"), manager.GetString("error"));
                        ImportPortraitForm_Shown(null, null); // try again
                        return;
                    }
                    imageLabel.Size = currentImage.Size;
                    imageLabel.Image = currentImage;
                }
                catch // if the file is not an image, an OutOfMemoryException is thrown. 0.o.
                {
                    Visible = false;
                }
            }
            else
            {
                Visible = false;
            }
        }

        private void ImportPortraitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            currentImage = null;
            imageLabel.Image = null;
            scale.Value = 100;
            okButton.Enabled = false;
        }

        private void scale_ValueChanged(object sender, EventArgs e)
        {
            if (currentImage != null)
            {
                mousePosition = NULL_POINT;
                selection = NULL_POINT;
                okButton.Enabled = false;

                Size oldSize = currentImage.Size;
                Size minimumSize = (oldSize.Width > oldSize.Height) ?
                    new Size((int)(141.0 * oldSize.Width / oldSize.Height), 141) :
                    new Size(141, (int)(141.0 * oldSize.Height / oldSize.Width));

                int newWidth = minimumSize.Width +
                    (int)((oldSize.Width - minimumSize.Width) * (scale.Value / 100.0));
                int newHeight = minimumSize.Height +
                    (int)((oldSize.Height - minimumSize.Height) * (scale.Value / 100.0));

                Image scaledImage = new Bitmap(newWidth, newHeight);
                Graphics g = Graphics.FromImage(scaledImage);
                g.DrawImage(currentImage, new Rectangle(Point.Empty, scaledImage.Size));
                g.Dispose();

                imageLabel.Size = scaledImage.Size;
                imageLabel.Image = scaledImage;
            }
        }

        private void imageLabel_MouseLeave(object sender, EventArgs e)
        {
            mousePosition = NULL_POINT;
            imageLabel.Refresh();
        }

        private void imageLabel_MouseMove(object sender, MouseEventArgs e)
        {
            int x = Math.Max(0, Math.Min(imageLabel.Size.Width  - 141, e.X - 70));
            int y = Math.Max(0, Math.Min(imageLabel.Size.Height - 141, e.Y - 70));
            mousePosition = new Point(x, y);
            imageLabel.Refresh();
        }

        private void imageLabel_Paint(object sender, PaintEventArgs e)
        {
            if (mousePosition != NULL_POINT)
            {
                e.Graphics.DrawImage(LotroSignatures.Properties.Resources.stencil, mousePosition.X, mousePosition.Y, 141, 141);
            }
            if (selection != NULL_POINT)
            {
                e.Graphics.DrawImage(LotroSignatures.Properties.Resources.stencil_red, selection.X, selection.Y, 141, 141);
            }
        }

        private void imageLabel_Click(object sender, EventArgs e)
        {
            selection = mousePosition;
            okButton.Enabled = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (PortraitSelected != null)
            {
                Bitmap scaledImage = new Bitmap(imageLabel.Size.Width, imageLabel.Size.Height);
                Graphics g = Graphics.FromImage(scaledImage);
                g.DrawImage(currentImage, new Rectangle(Point.Empty, scaledImage.Size));
                g.Dispose();

                ProgressDialog progress = new ProgressDialog(manager);
                Thread t = new Thread(delegate(Object obj)
                {
                    Bitmap ret = new Bitmap(141, 141);
                    for (int x = 0; x < 141; x++)
                    {
                        for (int y = 0; y < 141; y++)
                        {
                            Color stencilColor = LotroSignatures.Properties.Resources.stencil.GetPixel(x, y);
                            if (stencilColor.A > 128) // black area, opaque => make transparent
                            {
                                ret.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                            }
                            else
                            {
                                ret.SetPixel(x, y, scaledImage.GetPixel(selection.X + x, selection.Y + y));
                            }
                        }
                        Invoke(new ProgressDialog.setValueDelegate(progress.SetValue), new object[] { (int)(x / 1.41) });
                    }
                    Invoke(new FireEventDelegate(FireEvent), new object[] { ret });
                    Invoke(new ProgressDialog.setValueDelegate(progress.SetValue), new object[] { 100 });
                });

                t.Start(progress);
                progress.ShowDialog(this);
            }
            this.Visible = false;
        }

        public delegate void PortraitSelectedDelegate(Image portrait);
        public event PortraitSelectedDelegate PortraitSelected;

        private delegate void FireEventDelegate(Bitmap ret);
        private void FireEvent(Bitmap ret)
        {
            PortraitSelected(ret);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
