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
                LoadImage();
                LoadPictureBoxOtherChannel();
            }
        }

        private void LoadImage()
        {
            brightness = 255;
            hsiValues = new HSI[image.Width][];
            for (int i = 0; i < image.Width; i++)
            {
                hsiValues[i] = new HSI[image.Height];
            }

            Bitmap bitmap = (Bitmap)image;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    RGB rgb = new RGB(pixel.R, pixel.G, pixel.B);
                    hsiValues[x][y] = Utils.ToHSI(rgb);
                    if(x == 53 && y == 64)
                    Console.WriteLine($"Created a new value in hsiValues\nPosition is x: {x}, y: {y}\nValue is: H: {hsiValues[x][y].H}, S: {hsiValues[x][y].S}, I: {hsiValues[x][y].I}\nValues a rgb: R: {rgb.R}, G: {rgb.G}, B: {rgb.B}\n");
                    brightness = Math.Min(brightness, hsiValues[x][y].I);
                }
            }
        }

        private void LoadPictureBoxOtherChannel()
        {
            int width = image.Width;
            int height = image.Height;

            Bitmap imageBitmapR = new Bitmap(width, height);
            Bitmap imageBitmapG = new Bitmap(width, height);
            Bitmap imageBitmapB = new Bitmap(width, height);
            Bitmap imageBitmapH = new Bitmap(width, height);
            Bitmap imageBitmapS = new Bitmap(width, height);
            Bitmap imageBitmapI = new Bitmap(width, height);

            for(int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    RGB rgb = Utils.ToRGB(hsiValues[x][y]);
                    imageBitmapR.SetPixel(x, y, Color.FromArgb(rgb.R, 0, 0));
                    imageBitmapG.SetPixel(x, y, Color.FromArgb(0, rgb.G, 0));
                    imageBitmapB.SetPixel(x, y, Color.FromArgb(0, 0, rgb.B));
                    int hScale = (int)(hsiValues[x][y].H / 360.0 * 255.0);
                    int sScale = (int)(hsiValues[x][y].S / 100.0 * 255.0);
                    int iScale = (int)hsiValues[x][y].I;
                    imageBitmapH.SetPixel(x, y, Color.FromArgb(hScale, hScale, hScale));
                    imageBitmapS.SetPixel(x, y, Color.FromArgb(sScale, sScale, sScale));
                    imageBitmapI.SetPixel(x, y, Color.FromArgb(iScale, iScale, iScale));
                }
            }
            pictureBoxR.Image = imageBitmapR;
            pictureBoxG.Image = imageBitmapG;
            pictureBoxB.Image = imageBitmapB;
            pictureBoxH.Image = imageBitmapH;
            pictureBoxS.Image = imageBitmapS;
            pictureBoxI.Image = imageBitmapI;
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
