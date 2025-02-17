using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;
        private double brightness;
        private HSI[][] hsiValues;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void openImage(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictBoxImg1.Image = image;
                pictBoxImg1.SizeMode = PictureBoxSizeMode.Normal;
                loadImage();
            }
        }

        private void loadImage()
        {
            brightness = 255;
            hsiValues = new HSI[image.Height][];
            for (int i = 0; i < image.Height; i++)
            {
                hsiValues[i] = new HSI[image.Width];
            }

            for(int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color pixel = ((Bitmap)image).GetPixel(j, i);
                    RGB rgb = new RGB(pixel.R, pixel.G, pixel.B);
                    hsiValues[i][j] = Utils.ToHSI(rgb);
                    if(hsiValues[i][j].I < brightness)
                    {
                        brightness = hsiValues[i][j].I;
                    }
                }
            }
        }

        private void AddBrightnessButton(object sender, EventArgs e)
        {
            if(brightness < 255)
            {
                brightness += 10;
                imageBitmap = new Bitmap(image);
                ColorManipulator.AddBrightness(imageBitmap, hsiValues);
                pictBoxImg1.Image = imageBitmap;
            }
        }

        private void RemoveBrightnessButton(object sender, EventArgs e)
        {

        }
    }
}
