using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    public partial class Form1 : Form
    {
        Bitmap[] memory = new Bitmap[3];
        int ind = 2;
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
            }
            pictureBox1.Image = image;
            memory[ind] = image;
            ind--;
            pictureBox1.Refresh();
           
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void увеличениеЯркостиНаКонстантуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter_Brightness filter = new Filter_Brightness();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void бинаризацияПоПорогоуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilterBlack_White filter = new InvertFilterBlack_White();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void конвертацияВОттенкиСерогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFiltersGrey filter = new InvertFiltersGrey();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void гаусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }


        private void сепияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filters filter = new InvertSepia();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void сверткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SvertkaFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }
        private void переносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new TransferFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new TurnFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {

                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void наОдинШагToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (memory[1] != null)
            {
                pictureBox1.Image = memory[1];
                memory[2] = memory[1];
                memory[0] = null;
            }
        }

        private void на2ШагаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (memory[0] != null)
            {
                pictureBox1.Image = memory[0];
                memory[2] = memory[0];
                memory[1] = null;
                memory[0] = null;
            }
        }
    }
}
    
