using System.Drawing.Imaging;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        ImageList imageList = new ImageList(); // Bad practice, put this into the method that uses it       

        public Form1()
        {
            InitializeComponent();
        }        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|" +
                "*.bmp;" +
                "*.gif;" +
                "*.jpg;*.jpeg;" +
                "*.png";

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

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Decreases the brightness of an image.
        // 
        // This will cause the image to lose it's original color values, so make sure to keep a copy of the original image.
        private void decreaseBrightnessImageMenuStrip_Click(object sender, EventArgs e)
        {
            Image image = ViewPort.Image;
            Bitmap bitmapInverted = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {    1,     0,     0, 0, 0},
                    new float[] {    0,     1,     0, 0, 0},
                    new float[] {    0,     0,     1, 0, 0},
                    new float[] {    0,     0,     0, 1, 0},
                    new float[] {-0.1f, -0.1f, -0.1f, 1, 1},
                });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapInverted);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();

            ViewPort.Image = bitmapInverted;
        }

        // Increases the brightness of an image.
        // 
        // This will cause the image to lose it's original color values, so make sure to keep a copy of the original image.
        private void increaseBrightnessImageMenuStrip_Click(object sender, EventArgs e)
        {
            Image image = ViewPort.Image;
            Bitmap bitmapInverted = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {   1,    1,    1, 0, 0},
                    new float[] {   0,    1,    0, 0, 0},
                    new float[] {   0,    0,    1, 0, 0},
                    new float[] {   0,    0,    0, 1, 0},
                    new float[] {0.1f, 0.1f, 0.1f, 1, 1},
                });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapInverted);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();

            ViewPort.Image = bitmapInverted;
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

        private void convertToGrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copyBitmap = new Bitmap((Bitmap)ViewPort.Image);
            ProcessImage(copyBitmap);
            ViewPort.Image = copyBitmap;
        }

        private void convertToNegativeMenuImageStrip_Click(object sender, EventArgs e)
        {
            Image image = ViewPort.Image;
            Bitmap bitmapInverted = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {-1, 0, 0,  0, 0}, // Invert all red in the image
                    new float[] {0, -1, 0,  0, 0}, // Invert all green in the image
                    new float[] {0,  0, -1, 0, 0}, // Invert all blue in the image
                    new float[] {0,  0,  0, 1, 0}, // Alpha scaling factor of 1
                    new float[] {1,  1,  1, 0, 1}, // Three translations of 1
                });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapInverted);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();

            ViewPort.Image = bitmapInverted;
        }

        private void flipHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPort.Image.RotateFlip(RotateFlipType.RotateNoneFlipX); // Flip Horizontally
            ViewPort.Refresh();
        }

        private void flipVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPort.Image.RotateFlip(RotateFlipType.RotateNoneFlipY); // Flip Vertically
            ViewPort.Refresh();
        }
        private void rotatePlus90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPort.Image.RotateFlip(RotateFlipType.Rotate90FlipNone); // Rotate 90° Clockwise
            ViewPort.Refresh();
        }

        private void rotateMinus90ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // RotateFlip does not support negative rotations, but rotating 270° clockwise is the same as rotating -90° counterclockwise
            ViewPort.Image.RotateFlip(RotateFlipType.Rotate270FlipNone); // Rotate 270° Clockwise
            ViewPort.Refresh();
        }

        private void exportFramesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameDimension frameDimension = new FrameDimension(ViewPort.Image.FrameDimensionsList[0]);

            int frameCount = ViewPort.Image.GetFrameCount(frameDimension);
            toolStripFrameCount.Text = "Frames: " + frameCount.ToString();

            Image[] getFrames = new Image[frameCount];



            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string filePath = dialog.SelectedPath;

                for (int i = 0; i < frameCount; i++) // Retrieve and export frames
                {
                    ViewPort.Image.SelectActiveFrame(frameDimension, i);

                    getFrames[i] = new Bitmap(ViewPort.Image); // Store the current frame in the array
                    TransferPort.Image = getFrames[i];

                    string path = Path.Combine(filePath, string.Format("Sprite-{0}.png", i));
                    TransferPort.Image.Save(path);
                }

                MessageBox.Show("The program exported " + frameCount + " frames succesfully!");
            }
        }
    }
}