using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace ImgProcessingApp
{
    public partial class Form1 : Form
    {
        Bitmap originalImage;
        Bitmap processedImage;
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e) // load button ni sya
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(ofd.FileName);
                processedImage = new Bitmap(originalImage);
                pictureBox1.Image = originalImage;
                pictureBox2.Image = null;
            }
        }

        private void button8_Click(object sender, EventArgs e) // save button ni sya
        {
            if (processedImage == null) return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPEG|*.jpg|Bitmap|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                processedImage.Save(sfd.FileName);
                MessageBox.Show("Image saved successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e) // grayscale button ni sya 
        {
            if (originalImage == null) return;
            Bitmap gray = new Bitmap(originalImage.Width, originalImage.Height);
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color c = originalImage.GetPixel(x, y);
                    int grayValue = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                    gray.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }
            processedImage = gray;
            pictureBox2.Image = processedImage;
        }

        private void button7_Click(object sender, EventArgs e) // copy button ni sya
        {
            if (originalImage == null) return;

            processedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    processedImage.SetPixel(x, y, pixelColor);
                }
            }

            pictureBox2.Image = processedImage;
        }

        private void button2_Click(object sender, EventArgs e) // inverion button ni sya
        {
            if (originalImage == null) return;
            Bitmap inverted = new Bitmap(originalImage.Width, originalImage.Height);
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color c = originalImage.GetPixel(x, y);
                    inverted.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            processedImage = inverted;
            pictureBox2.Image = processedImage;
        }

        private void button3_Click(object sender, EventArgs e) // sepia button ni sya
        {
            if (originalImage == null) return;
            Bitmap sepia = new Bitmap(originalImage.Width, originalImage.Height);
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color c = originalImage.GetPixel(x, y);
                    int tr = (int)(0.393 * c.R + 0.769 * c.G + 0.189 * c.B);
                    int tg = (int)(0.349 * c.R + 0.686 * c.G + 0.168 * c.B);
                    int tb = (int)(0.272 * c.R + 0.534 * c.G + 0.131 * c.B);
                    tr = Math.Min(255, tr);
                    tg = Math.Min(255, tg);
                    tb = Math.Min(255, tb);
                    sepia.SetPixel(x, y, Color.FromArgb(tr, tg, tb));
                }
            }
            processedImage = sepia;
            pictureBox2.Image = processedImage;
        }

        private void button4_Click(object sender, EventArgs e) // histogram ni sya
        {
            if (processedImage == null) return;

            int[] histogram = new int[256];
            for (int y = 0; y < processedImage.Height; y++)
            {
                for (int x = 0; x < processedImage.Width; x++)
                {
                    Color c = processedImage.GetPixel(x, y);
                    int gray = (c.R + c.G + c.B) / 3;
                    histogram[gray]++;
                }
            }

            int max = 0;
            foreach (int val in histogram)
                if (val > max) max = val;

            int width = pictureBox2.ClientSize.Width;
            int height = pictureBox2.ClientSize.Height;
            Bitmap histBmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(histBmp))
            {
                g.Clear(pictureBox2.BackColor);

                float barWidth = (float)width / 256f;

                for (int i = 0; i < 256; i++)
                {
                    float barHeight = (histogram[i] / (float)max) * (height - 1);

                    g.FillRectangle(Brushes.Black,
                        i * barWidth,
                        height - barHeight,
                        barWidth,
                        barHeight);
                }
            }

            pictureBox2.Image = histBmp;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
                form2 = new Form2(this);

            form2.Show();
            this.Hide();
        }
    }
}
