using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace EditorPoze
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
        string ImagePath = String.Empty;

        Bitmap imageNew;
        Image image2;
        Image image3 = new Bitmap(1, 1);

        public int valoareLum, valoareCon, valoareSat;


        //Adauga o imagine in editor;
        private void ButonADD_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog AlegeImagine = new OpenFileDialog
                {
                    Filter = "Image Files(*.png, *.jpg, *.bmp)|*.png;*.jpg;*.bmp|All Files(*.*)|*.*",
                    Title = "Alege imaginea pe care vrei sa o editezi."
                };

                if (AlegeImagine.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = AlegeImagine.FileName;
                    imageNew = new Bitmap(ImagePath);
                    UpdatePictureBox();
                    PictureEditor.Image = imageNew;
                    image2 = new Bitmap(ImagePath);
                }
                AlegeImagine.Dispose();
            }
            catch
            {
                MessageBox.Show("Fisierul ales nu este o imagine ...(.jpg, .png .bmp, etc.)!", "Fisier incorect", MessageBoxButtons.OK);
            }
        }

        //Aduaga imaginea pe afisaj;
        public void UpdatePictureBox()
        {
            ButonADD.Hide();
            label1.Hide();
            panel1.Show();
        }


        //Anuleaza editarea si revine la fereastra initiala;
        private void AnuleazaEditarea_onClick(object sender, System.EventArgs e)
        {
            DialogResult Buton1Result = MessageBox.Show("Sunteti sigur ca vreti sa anulati editarea?", "Sunteti sigur?", MessageBoxButtons.YesNo);
            if (Buton1Result == DialogResult.Yes)
            {
                ButonADD.Show();
                label1.Show();
                panel1.Hide();
                image2.Dispose();
                imageNew.Dispose();
                Reset();

            }
        }

        //Salveaza imaginea;
        private void SalveazaImaginea_onClick(object sender, System.EventArgs e)
        {
            SaveFileDialog SalveazaEditarea = new SaveFileDialog
            {
                Filter = "Image Files(*.png, *.jpg, *.bmp)|*.png;*.jpg;*.bmp|All Files(*.*)|*.*",
                Title = "Alege locatia unde vrei sa salvezi imaginea.",
                DefaultExt = "*.jpg",
                AddExtension = true
            };

            if (SalveazaEditarea.ShowDialog() == DialogResult.OK)
            {
                PictureEditor.Image.Save(SalveazaEditarea.FileName);
                MessageBox.Show("Imaginea s-a salvat cu succes!", "Salvare reusita.", MessageBoxButtons.OK);
            }

            SalveazaEditarea.Dispose();

        }

        //Restabileste Imaginea initiala;
        private void RestabilireImagine_onClick(object sender, System.EventArgs e)
        {
            image2.Dispose();
            imageNew.Dispose();
            image2 = new Bitmap(ImagePath);
            imageNew = new Bitmap(ImagePath);
            PictureEditor.Image = imageNew;
            Reset();

        }

        //Reseteaza valorile controalelor;
        private void Reset()
        {
            radioGrayscale.Checked = false;
            radioNegativ.Checked = false;
            radioSepia.Checked = false;
            radioPolaroid.Checked = false;

            trackRed.Value = 0;
            trackGreen.Value = 0;
            trackBlue.Value = 0;

            trackRed.Enabled = true;
            trackGreen.Enabled = true;
            trackBlue.Enabled = true;

            trackLuminozitate.Value = 0;
            trackContrast.Value = 10;
            trackSaturatie.Value = 10;

            ValoareLum.Text = "0";
            ValoareCon.Text = "0";
            ValoareSat.Text = "0";

            GC.Collect();
        }

        //Aplica efectul de culoare (hue);
        private void Editare_Culoare()
        {
            float Red, Green, Blue;
            int width = imageNew.Width;
            int height = imageNew.Height;
            image2.Dispose();
            image2 = new Bitmap(width, height);
            ImageAttributes imageAtr = new ImageAttributes();

            Red = 1 + trackRed.Value * 0.05f;
            Green = 1 + trackGreen.Value * 0.05f;
            Blue = 1 + trackBlue.Value * 0.05f;

            float[][] colorMatrixElements ={
               new float[] {Red,  0,  0,  0, 0},
               new float[] {0,  Green,  0,  0, 0},
               new float[] {0,  0,  Blue,  0, 0},
               new float[] {0,  0,  0,  1, 0},
               new float[] {0,  0,  0,  0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            imageAtr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Graphics G = Graphics.FromImage(image2);
            G.DrawImage(imageNew, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAtr);
            G.Dispose();
            imageAtr.Dispose();
            Ajusteaza_Imaginea();

        }

        //Aplica efectul ales (Sepia, GrayScale sau Negativ);
        private void AplicaEfect_Click(object sender, EventArgs e)
        {

            if (radioSepia.Checked == true || radioGrayscale.Checked == true || radioNegativ.Checked == true || radioPolaroid.Checked == true)
            {
                trackRed.Value = 0;
                trackGreen.Value = 0;
                trackBlue.Value = 0;
                trackRed.Enabled = false;
                trackGreen.Enabled = false;
                trackBlue.Enabled = false;
                if (radioSepia.Checked == true)
                    AplicaSepia();
                else if (radioGrayscale.Checked == true)
                    AplicaGrayscale();
                else if (radioNegativ.Checked == true)
                    AplicaNegativ();
                else if (radioPolaroid.Checked == true)
                    AplicaOldImage();
            }
            Ajusteaza_Imaginea();
        }

        //Aplica imaginii efectul de sepia;
        private void AplicaSepia()
        {
            int width = imageNew.Width;
            int height = imageNew.Height;
            image2.Dispose();
            image2 = new Bitmap(width, height);
            ImageAttributes imageAtr = new ImageAttributes();

            float[][] colorMatrixElements ={
               new float[] {0.393f, 0.349f, 0.272f, 0, 0},
               new float[] {0.769f, 0.686f, 0.534f, 0, 0},
               new float[] {0.189f, 0.168f, 0.131f,  0, 0},
               new float[] {0,  0,  0,  1, 0},
               new float[] {0,  0,  0,  0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            imageAtr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Graphics G = Graphics.FromImage(image2);
            G.DrawImage(imageNew, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAtr);
            imageAtr.Dispose();
            G.Dispose();
        }

        //Aplica imaginii efectul de Grayscale;
        private void AplicaGrayscale()
        {
            int width = imageNew.Width;
            int height = imageNew.Height;
            image2.Dispose();
            image2 = new Bitmap(width, height);
            ImageAttributes imageAtr = new ImageAttributes();

            float[][] colorMatrixElements ={
               new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                new float[] { 0,      0,      0,      1, 0 },
                new float[] { 0,      0,      0,      0, 1 }};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            imageAtr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Graphics G = Graphics.FromImage(image2);
            G.DrawImage(imageNew, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAtr);
            imageAtr.Dispose();
            G.Dispose();
        }

        //Aplica imaginii efectul de Negativ;
        private void AplicaNegativ()
        {
            int width = imageNew.Width;
            int height = imageNew.Height;
            image2.Dispose();
            image2 = new Bitmap(width, height);
            ImageAttributes imageAtr = new ImageAttributes();

            float[][] colorMatrixElements ={
               new float[] {-1,  0,  0,  0, 0},
               new float[] {0,  -1,  0,  0, 0},
               new float[] {0,  0,  -1,  0, 0},
               new float[] {0,  0,  0,  1, 0},
               new float[] {1,  1,  1,  0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            imageAtr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Graphics G = Graphics.FromImage(image2);
            G.DrawImage(imageNew, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAtr);
            imageAtr.Dispose();
            G.Dispose();
        }

        //Aplica imaginii efectul de Polaroid;
        private void AplicaOldImage()
        {
            int width = imageNew.Width;
            int height = imageNew.Height;
            image2.Dispose();
            image2 = new Bitmap(width, height);
            ImageAttributes imageAtr = new ImageAttributes();

            float[][] colorMatrixElements ={
               new float[] {0.3f,  0.3f,  0.3f, 0, 0 },
                new float[] {0.55f,  0.55f,   0.55f, 0, 0 },
                new float[] {0.130f, 0.130f,  0.130f, 0, 0 },
                new float[] { 0,      0,      0,      1, 0 },
                new float[] { 0.2f,  0.2f,  0.2f, 0, 1 }};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            imageAtr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Graphics G = Graphics.FromImage(image2);
            G.DrawImage(imageNew, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAtr);
            imageAtr.Dispose();
            G.Dispose();

            image3.Dispose();
            image3 = new Bitmap(EditorPoze.Properties.Resources.OldPaper, width, height);

            imageAtr = new ImageAttributes();

            float[][] colorMatrixElements2 ={
               new float[] {1,     0,     0,     0,    0 },
               new float[] {0,     1,     0,     0,    0 },
               new float[] {0,     0,     1,     0,    0 },
               new float[] {0,     0,     0,     0.5f, 0 },
               new float[] {-0.1f, -0.1f, -0.1f, 0,    1 }};

            ColorMatrix colorMatrix2 = new ColorMatrix(colorMatrixElements2);
            imageAtr.SetColorMatrix(colorMatrix2, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            G = Graphics.FromImage(image2);
            G.DrawImage(image3, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAtr);
            imageAtr.Dispose();
            G.Dispose();
        }

        //Schimba contrastul
        private void TrackRed_ValueChanged(object sender, EventArgs e)
        {
            Editare_Culoare();
        }

        private void TrackGreen_ValueChanged(object sender, EventArgs e)
        {
            Editare_Culoare();
        }

        private void TrackBlue_ValueChanged(object sender, EventArgs e)
        {
            Editare_Culoare();
        }

        //Schimba contrastul
        private void TrackContrast_Scroll(object sender, EventArgs e)
        {
            ValoareCon.Text = Convert.ToString(trackContrast.Value - 10);
            Ajusteaza_Imaginea();
        }

        //Schimba luminozitatea;
        private void TrackLuminozitate_Scroll(object sender, EventArgs e)
        {
            ValoareLum.Text = Convert.ToString(trackLuminozitate.Value);
            Ajusteaza_Imaginea();
        }

        //Schimba saturatia;
        private void TrackSaturatie_Scroll(object sender, EventArgs e)
        {
            ValoareSat.Text = Convert.ToString(trackSaturatie.Value - 10);
            Ajusteaza_Imaginea();
        }

        private void Ajusteaza_Imaginea()
        {
            float b, c, s, t, sr, sg, sb;
            int width = imageNew.Width;
            int height = imageNew.Height;
            image3.Dispose();
            image3 = new Bitmap(width, height);

            ImageAttributes imageAtr = new ImageAttributes();
            b = (trackLuminozitate.Value) * 0.02f;

            c = (trackContrast.Value * 0.1f) * 0.5f + 0.5f;
            t = (1.0f - c) * 0.5f;

            s = (trackSaturatie.Value *0.1f) * 0.9f + 0.1f;
            sr = (1.0f - s) * 0.2125f;
            sg = (1.0f - s) * 0.7154f;
            sb = (1.0f - s) * 0.0721f;


            float[][] colorMatrixElements ={
               new float[] {c*(sr+s), c*(sr),  c*(sr),  0, 0},
               new float[] {c*(sg), c*(sg+s), c*(sg),  0, 0},
               new float[] {c*(sb),  c*(sb), c*(sb+s),  0, 0},
               new float[] {0,  0,  0,  1, 0},
               new float[] {t+b,  t+b,  t+b,  0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            imageAtr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Graphics G = Graphics.FromImage(image3);
            G.DrawImage(image2, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel, imageAtr);
            imageAtr.Dispose();
            G.Dispose();
            PictureEditor.Image = image3;
        }
    }
}
