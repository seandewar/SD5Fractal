using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD5Fractal
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Bitmap im;

        private long Mandelbrot(
            int resX = 1024, int resY = 720, 
            int maxIterations = 500,
            double startCRe = -2.5, double endCRe = 1.5,
            double startCIm = -1.5, double endCIm = 1.5,
            bool r = true, bool g = true, bool b = true,
            bool colorMandelbrot = true,
            bool zSq = true
            )
        {
            long totalIterations = 0;

            //double startCRe = -2.5;
            //double endCRe = 1.5;
            //double startCIm = -1.5;
            //double endCIm = 1.5;

            //double startCRe = -0.705;
            //double endCRe = -0.704;
            //double startCIm = -0.296;
            //double endCIm = -0.295;

            im = new Bitmap(resX, resY);

            for (int x = 0; x < resX; ++x)
            {
                for (int y = 0; y < resY; ++y)
                {
                    double zRe = 0.0;
                    double zIm = 0.0;

                    double cRe = startCRe + ((x / (double)resX) * (endCRe - startCRe));
                    double cIm = startCIm + ((y / (double)resY) * (endCIm - startCIm));

                    int iteration = 0;
                    for (; iteration < maxIterations; ++iteration)
                    {
                        ++totalIterations;

                        double zReSq = 0.0;
                        double zImSq = 0.0;

                        if (zSq)
                        {
                            //Square z_n
                            zReSq = (zRe * zRe) - (zIm * zIm);
                            zImSq = 2 * zRe * zIm;
                        }
                        else
                        {
                            //Cube z_n
                            zReSq = (zRe * zRe * zRe) - 3 * zRe * (zIm * zIm);
                            zImSq = 3 * (zRe * zRe) * zIm - (zIm * zIm * zIm);
                        }

                        zRe = zReSq + cRe;
                        zIm = zImSq + cIm;

                        //If modulus of z_(n+1) is < 2, then not in set
                        //TO INFINITY & BEYOND!
                        //Check if c is in not part of the set...
                        if ((zRe * zRe) + (zIm * zIm) >= 4)
                            break;
                    }

                    double colorFactor = (iteration / (double)maxIterations);

                    if (!colorMandelbrot && iteration == maxIterations)
                    {
                        im.SetPixel(x, y, Color.Black);
                        continue;
                    }

                    im.SetPixel(
                        x, y,
                        Color.FromArgb(
                        (int)Math.Round(colorFactor * 255) * (r ? 1 : 0),
                            (int)Math.Round(colorFactor * 255) * (g ? 1 : 0),
                            (int)Math.Round(colorFactor * 255) * (b ? 1 : 0))
                        );
                }
            }

            pictureBoxView.Image = im;
            return totalIterations;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Mandelbrot();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int ImgX = 0;
            int ImgY = 0;

            if (!int.TryParse(textBoxImX.Text, out ImgX) ||
                !int.TryParse(textBoxImY.Text, out ImgY))
            {
                MessageBox.Show(this, "Invalid render resolution.");
                return;
            }

            int maxIterations = (int)numericUpDownMaxIt.Value;
            double cRe = 0.0;
            double cReE = 0.0;
            double cIm = 0.0;
            double cImE = 0.0;

            if (!double.TryParse(textBoxCRe.Text, out cRe) ||
                !double.TryParse(textBoxCIm.Text, out cIm) ||
                !double.TryParse(textBoxCReE.Text, out cReE) ||
                !double.TryParse(textBoxCImE.Text, out cImE))
            {
                MessageBox.Show(this, "The value of start or end c is not a valid complex number.");
                return;
            }

            buttonGenerate.Enabled = false;
            buttonGenerate.Text = "Generating...";
            buttonGenerate.Refresh();

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            long totalIt = Mandelbrot(ImgX, ImgY, maxIterations, cRe, cReE, cIm, cImE, 
                checkBoxR.Checked, checkBoxG.Checked, checkBoxB.Checked,
                checkBoxColourSet.Checked, radioButtonMandelbrotZSq.Checked);

            sw.Stop();

            labelStats.Text = "Total iterations: " + totalIt + Environment.NewLine +
                "Average iteration per pixel: " + (totalIt / (double)(ImgX * ImgY)) + Environment.NewLine +
                "Total generation time: " + sw.ElapsedMilliseconds + "ms";

            buttonGenerate.Enabled = true;
            buttonGenerate.Text = "Generate";
            buttonGenerate.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bitmap file (*.bmp)|*.bmp";
            save.FilterIndex = 0;
            save.FileName = "Mandelbrot";
            save.RestoreDirectory = true;

            if (save.ShowDialog(this) == DialogResult.OK)
            {
                im.Save(save.FileName);
            }
        }

        private void labelStats_Click(object sender, EventArgs e)
        {

        }
    }
}
