using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertBackgroundIntoFrames
{
    public partial class BackgroundFrames : Form
    {
        public BackgroundFrames()
        {
            InitializeComponent();
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSlctPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png"
                + "|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                Image bg = Image.FromFile(ofd.FileName);
                txtWidth.Text = bg.Width.ToString(); 
                txtHeight.Text = bg.Height.ToString(); 
            }

            else txtPath.Text = "";
        }

        private void btnSlctFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txtFolder.Text = fbd.SelectedPath;
            else txtFolder.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bg = (Bitmap)Image.FromFile(txtPath.Text);
                bg = ResizeBackground(bg);
                int idx = 0;
                while (idx < bg.Width)
                {
                    bg.Save(Path.Combine(txtFolder.Text
                        , txtPrefix.Text + idx.ToString() + ".png"));

                    Bitmap bmp = new Bitmap(bg.Width, bg.Height);
                    for (int y = 0; y < bg.Height; y++)
                        bmp.SetPixel(bg.Width - 1, y, bg.GetPixel(0, y));

                    for (int x = 1; x < bg.Width; x++)
                        for (int y = 0; y < bg.Height; y++)
                            bmp.SetPixel(x - 1, y, bg.GetPixel(x, y));
                    bg = bmp;
                    idx += 1;
                }
                MessageBox.Show("Operation Complete Successfully");

            }
            catch
            {
                MessageBox.Show("Fatel Error");
            }
        }

        private Bitmap ResizeBackground(Bitmap bmp)
        {
            int w = int.Parse(txtWidth.Text), h = int.Parse(txtHeight.Text);
            Bitmap ans = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(ans);
            graphic.DrawImage(bmp, 0, 0, w + (w / bmp.Width), h);
            graphic.Dispose();
            return ans;
        }
    }
}
