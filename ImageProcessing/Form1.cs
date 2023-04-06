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

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    ViewPort.Image = new Bitmap(openFile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Incompatible Extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessImage(Bitmap bmp) // Convert Image to Grayscale
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

        private void viewFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 < viewFrames.SelectedItems.Count)
            {
                var item = viewFrames.SelectedItems[0];
                Image image = imageList.Images[item.ImageIndex];
                ViewPort.Image = image;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    ViewPort.Image = new Bitmap(openFile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Incompatible Extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter =
                "Bitmap(*.bmp)|*.bmp|" +
                "GIF(*.gif)|*.gif|" +
                "JPEG(*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "PNG(*.png)|*.png";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                ViewPort.Image.Save(saveFile.FileName);
            }
        }

        private void convertToGrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copyBitmap = new Bitmap((Bitmap)ViewPort.Image);
            ProcessImage(copyBitmap);
            ViewPort.Image = copyBitmap;
        }

        private void retrieveFramesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameDimension frameDimension = new FrameDimension(ViewPort.Image.FrameDimensionsList[0]);

            int frameCount = ViewPort.Image.GetFrameCount(frameDimension);
            toolStripFrameCount.Text = "Frames: " + frameCount.ToString();

            for (int i = 0; i < frameCount; i++)
            {
                ViewPort.Image.SelectActiveFrame(new FrameDimension(ViewPort.Image.FrameDimensionsList[0]), i); // Retrieve all frames
                imageList.ImageSize = new Size(256, 100);

                viewFrames.LargeImageList = imageList;
                imageList.Images.Add(ViewPort.Image);

                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                viewFrames.Items.Add(item);
            }
        }

        private void clearFramesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripFrameCount.Text = "Frames: 0";
            viewFrames.Items.Clear(); // Clears the stored frames, otherwise the original image frames will still populate the list
            imageList.Images.Clear();
        }

        private void exportFramesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string filePath = dialog.SelectedPath;
                int index = 1;

                foreach (Image image in imageList.Images)
                {
                    string path = Path.Combine(filePath, string.Format("Sprite-{0}.png", index));
                    image.Save(path);
                    index++;
                }

                MessageBox.Show("Frames exported successfully!");
            }
        }
    }
}