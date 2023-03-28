using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e) // Import Image
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PictureUnaltered.Image = new Bitmap(openFile.FileName);
                PictureAltered.Image = new Bitmap(openFile.FileName);
            }
        }

        private void ButtonConvertToGrayscale_Click(object sender, EventArgs e) // Convert Image to Grayscale
        {
            Bitmap copyBitmap = new Bitmap((Bitmap)PictureAltered.Image);
            ProcessImage(copyBitmap);
            PictureAltered.Image = copyBitmap;
        }

        private void ProcessImage(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);

                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    int gray = (byte)(.299 * red + .587 * green + .114 * blue);

                    red = gray;
                    green = gray;
                    blue = gray;

                    bmp.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
        }

        private void ButtonSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "GIF(*.GIF)|*.gif|" +
                              "JPG(*.JPG)|*.jpg|" +
                              "PNG(*.PNG)|*.png";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                PictureAltered.Image.Save(saveFile.FileName); // Save the image from the processed image section
            }
        }
    }
}