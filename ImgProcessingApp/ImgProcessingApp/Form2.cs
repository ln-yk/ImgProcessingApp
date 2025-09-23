using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ImgProcessingApp
{
    public partial class Form2 : Form
    {
        Bitmap imageB, imageA, colorgreen;
        private Form1 parentForm;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // load button ni sya, load image B
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageB = new Bitmap(ofd.FileName);
                    pictureBox1.Image = imageB;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // load button ni sya, load image A
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageA = new Bitmap(ofd.FileName);
                    pictureBox2.Image = imageA;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // subtract button ni sya
        {
            if (imageA == null || imageB == null)
            {
                MessageBox.Show("Please load both images first.");
                return;
            }

            int width = Math.Min(imageA.Width, imageB.Width);
            int height = Math.Min(imageA.Height, imageB.Height);

            Bitmap resultImage = new Bitmap(width, height);

            Color mygreen = Color.FromArgb(0, 255, 0);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;

            int threshold = 20;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);

                    int grey = (pixel.R + pixel.G + pixel.B) / 3;

                    int subtractValue = Math.Abs(grey - greygreen);

                    if (subtractValue > threshold)
                        resultImage.SetPixel(x, y, pixel);
                    else
                        resultImage.SetPixel(x, y, backpixel);
                }
            }

            colorgreen = resultImage;
            pictureBox3.Image = colorgreen;
        }

        private void button5_Click(object sender, EventArgs e) // save button for the subtracted img
        {
            if (colorgreen == null)
            {
                MessageBox.Show("No result to save.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG|*.png|JPEG|*.jpg|Bitmap|*.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    colorgreen.Save(sfd.FileName);
                    MessageBox.Show("Subtracted image saved successfully!");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e) // clear button ni sya
        {
            if (pictureBox1.Image != null) { pictureBox1.Image.Dispose(); pictureBox1.Image = null; }
            if (pictureBox2.Image != null) { pictureBox2.Image.Dispose(); pictureBox2.Image = null; }
            if (pictureBox3.Image != null) { pictureBox3.Image.Dispose(); pictureBox3.Image = null; }

            imageA = null;
            imageB = null;
            colorgreen = null;
        }
    }
}
