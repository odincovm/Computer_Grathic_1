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
        public int[,] Mask;
        public Form1()
        {
            InitializeComponent();
            Mask = new int[3, 3] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
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
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
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

        private void поYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharraY();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
         
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void поXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharraX();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void поYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelY();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void поXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelX();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
           
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void поYToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new PruittY();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
          
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void поXToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new PruittX();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
        
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void вариант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new waves1();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
           
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void вариант2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new waves2();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void вToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFiltersGrey filter = new InvertFiltersGrey();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            Filters filter1 = new Crowding();
            Bitmap resultImage1 = filter.processImage(image);
            pictureBox1.Image = resultImage1;
            pictureBox1.Refresh();
            image = resultImage1;
            
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void motionBlureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Motionblur();
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

        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter();
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

        private void стеклаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Glass();
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

        private void расширениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Dilation(Mask);
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
         
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void сужениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Errosion(Mask);
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void открытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Filters filter1 = new Errosion(Mask);
            Bitmap resultImage1 = filter1.processImage(image);
            Filters filter2 = new Dilation(Mask);
            Bitmap resultImage2 = filter2.processImage(resultImage1);
            pictureBox1.Image = resultImage2;
            pictureBox1.Refresh();
            image = resultImage2;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void задатьСтруктурныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Mask[i, j]= (int)(textBox2.Text[i+j]-'0');
                }
            }
       
        }

        private void закрытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter2 = new Errosion(Mask);
            Filters filter1 = new Dilation(Mask);
            Bitmap resultImage1 = filter1.processImage(image);
            Bitmap resultImage2 = filter2.processImage(resultImage1);
            pictureBox1.Image = resultImage2;
            pictureBox1.Refresh();
            image = resultImage2;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }
  
        private void градиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grad filter = new Grad(Mask);
            Bitmap resultImage = filter.ProcessImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void серыйМирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayWorld filter = new GrayWorld();
            Bitmap resultImage = filter.processimage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void идеальныйОтражательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfectReflector filter = new PerfectReflector();
            Bitmap resultImage = filter.processimage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
        
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void корекцияСОпорнымЦветомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            Color r;
            if (F1.colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                r = F1.colorDialog1.Color;
            else return;
            CorrectionWithReferenceColor filter = new CorrectionWithReferenceColor(r);
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopHat filter = new TopHat();
            Bitmap resultImage = filter.processimage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackHat filter = new BlackHat();
            Bitmap resultImage = filter.processimage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;
        }

        private void светящиесяКраяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter();
            Bitmap resultImage = filter.processImage(image);
            Filters filter2 = new SobelY();
            resultImage = filter2.processImage(resultImage);
            Filters filter3 = new Glowingedges();
            resultImage = filter3.processImage(resultImage);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            image = resultImage;
            pictureBox1.Image = resultImage;
            memory[0] = memory[1];
            memory[1] = memory[2];
            memory[2] = image;

        }
    }
}
    
