using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        ImageList imageList = new ImageList();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonImport_Click(object sender, EventArgs e) // Import Image
        {
            OpenFileDialog openFile = new OpenFileDialog();

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    PictureUnaltered.Image = new Bitmap(openFile.FileName);
                    PictureAltered.Image = new Bitmap(openFile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Incompatible Extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ButtonExport_Click(object sender, EventArgs e)
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

        private void buttonRetrieveFrames_Click(object sender, EventArgs e)
        {
            FrameDimension frameDimension = new FrameDimension(PictureUnaltered.Image.FrameDimensionsList[0]);

            int frameCount = PictureUnaltered.Image.GetFrameCount(frameDimension);
            labelFrames.Text = "Frames: " + frameCount.ToString(); // Display how many frames are in the image

            for (int i = 0; i < frameCount; i++)
            {
                PictureUnaltered.Image.SelectActiveFrame(new FrameDimension(PictureUnaltered.Image.FrameDimensionsList[0]), i); // Retrieve all frames
                imageList.ImageSize = new Size(256, 100);

                viewFrames.LargeImageList = imageList;
                imageList.Images.Add(PictureUnaltered.Image);

                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                viewFrames.Items.Add(item);
            }
        }

        private void buttonClearFrames_Click(object sender, EventArgs e)
        {
            labelFrames.Text = "Frames: 0";
            viewFrames.Items.Clear(); // Clears the stored frames, otherwise the original image frames will still populate the list
            imageList.Images.Clear();
        }
    }
}