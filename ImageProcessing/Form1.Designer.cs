namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            FileMenu_Open = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            FileMenu_SaveAs = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            FileMenu_Quit = new ToolStripMenuItem();
            ImageMenu = new ToolStripMenuItem();
            ImageMenu_DecreaseBrightness = new ToolStripMenuItem();
            ImageMenu_IncreaseBrightness = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            ImageMenu_Grayscale = new ToolStripMenuItem();
            ImageMenu_Negative = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            ImageMenu_Transform = new ToolStripMenuItem();
            ImageMenu_Transform_FlipHorizontally = new ToolStripMenuItem();
            ImageMenu_Transform_FlipVertically = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ImageMenu_Transform_RotatePlus90 = new ToolStripMenuItem();
            ImageMenu_Transform_RotateMinus90 = new ToolStripMenuItem();
            AnimationMenu = new ToolStripMenuItem();
            AnimationMenu_CombineGIFFrames = new ToolStripMenuItem();
            AnimationMenu_ExportGIFFrames = new ToolStripMenuItem();
            AnimationMenu_ModifyGIFFrameDelay = new ToolStripMenuItem();
            AnimationMenu_ModifyGIFFrameDelay_Textbox = new ToolStripTextBox();
            ColorsMenu = new ToolStripMenuItem();
            ColorsMenu_ColorShift = new ToolStripMenuItem();
            ViewPort = new PictureBox();
            bindingSource1 = new BindingSource(components);
            ViewPortPanel = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ViewPortPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileMenu, ImageMenu, AnimationMenu, ColorsMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(864, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { FileMenu_Open, toolStripSeparator2, FileMenu_SaveAs, toolStripSeparator3, FileMenu_Quit });
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(37, 20);
            FileMenu.Text = "File";
            // 
            // FileMenu_Open
            // 
            FileMenu_Open.Name = "FileMenu_Open";
            FileMenu_Open.ShortcutKeys = Keys.Control | Keys.O;
            FileMenu_Open.Size = new Size(186, 22);
            FileMenu_Open.Text = "Open";
            FileMenu_Open.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(183, 6);
            // 
            // FileMenu_SaveAs
            // 
            FileMenu_SaveAs.Name = "FileMenu_SaveAs";
            FileMenu_SaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            FileMenu_SaveAs.Size = new Size(186, 22);
            FileMenu_SaveAs.Text = "Save As";
            FileMenu_SaveAs.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(183, 6);
            // 
            // FileMenu_Quit
            // 
            FileMenu_Quit.Name = "FileMenu_Quit";
            FileMenu_Quit.ShortcutKeys = Keys.Control | Keys.Q;
            FileMenu_Quit.Size = new Size(186, 22);
            FileMenu_Quit.Text = "Quit";
            FileMenu_Quit.Click += quitToolStripMenuItem_Click;
            // 
            // ImageMenu
            // 
            ImageMenu.DropDownItems.AddRange(new ToolStripItem[] { ImageMenu_DecreaseBrightness, ImageMenu_IncreaseBrightness, toolStripSeparator4, ImageMenu_Grayscale, ImageMenu_Negative, toolStripSeparator5, ImageMenu_Transform });
            ImageMenu.Name = "ImageMenu";
            ImageMenu.Size = new Size(52, 20);
            ImageMenu.Text = "Image";
            // 
            // ImageMenu_DecreaseBrightness
            // 
            ImageMenu_DecreaseBrightness.Name = "ImageMenu_DecreaseBrightness";
            ImageMenu_DecreaseBrightness.Size = new Size(180, 22);
            ImageMenu_DecreaseBrightness.Text = "Decrease Brightness";
            ImageMenu_DecreaseBrightness.Click += decreaseBrightnessImageMenuStrip_Click;
            // 
            // ImageMenu_IncreaseBrightness
            // 
            ImageMenu_IncreaseBrightness.Name = "ImageMenu_IncreaseBrightness";
            ImageMenu_IncreaseBrightness.Size = new Size(180, 22);
            ImageMenu_IncreaseBrightness.Text = "Increase Brightness";
            ImageMenu_IncreaseBrightness.Click += increaseBrightnessImageMenuStrip_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // ImageMenu_Grayscale
            // 
            ImageMenu_Grayscale.Name = "ImageMenu_Grayscale";
            ImageMenu_Grayscale.Size = new Size(180, 22);
            ImageMenu_Grayscale.Text = "Grayscale";
            ImageMenu_Grayscale.ToolTipText = "Get the grayscale of an image.";
            ImageMenu_Grayscale.Click += convertToGrayscaleToolStripMenuItem_Click;
            // 
            // ImageMenu_Negative
            // 
            ImageMenu_Negative.Name = "ImageMenu_Negative";
            ImageMenu_Negative.Size = new Size(180, 22);
            ImageMenu_Negative.Text = "Negative";
            ImageMenu_Negative.ToolTipText = "Get the negative equivalent of an image.";
            ImageMenu_Negative.Click += convertToNegativeMenuImageStrip_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // ImageMenu_Transform
            // 
            ImageMenu_Transform.DropDownItems.AddRange(new ToolStripItem[] { ImageMenu_Transform_FlipHorizontally, ImageMenu_Transform_FlipVertically, toolStripSeparator1, ImageMenu_Transform_RotatePlus90, ImageMenu_Transform_RotateMinus90 });
            ImageMenu_Transform.Name = "ImageMenu_Transform";
            ImageMenu_Transform.Size = new Size(180, 22);
            ImageMenu_Transform.Text = "Transform";
            // 
            // ImageMenu_Transform_FlipHorizontally
            // 
            ImageMenu_Transform_FlipHorizontally.Name = "ImageMenu_Transform_FlipHorizontally";
            ImageMenu_Transform_FlipHorizontally.Size = new Size(180, 22);
            ImageMenu_Transform_FlipHorizontally.Text = "Flip Horizontally";
            ImageMenu_Transform_FlipHorizontally.Click += flipHorizontallyToolStripMenuItem_Click;
            // 
            // ImageMenu_Transform_FlipVertically
            // 
            ImageMenu_Transform_FlipVertically.Name = "ImageMenu_Transform_FlipVertically";
            ImageMenu_Transform_FlipVertically.Size = new Size(180, 22);
            ImageMenu_Transform_FlipVertically.Text = "Flip Vertically";
            ImageMenu_Transform_FlipVertically.Click += flipVerticallyToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // ImageMenu_Transform_RotatePlus90
            // 
            ImageMenu_Transform_RotatePlus90.Name = "ImageMenu_Transform_RotatePlus90";
            ImageMenu_Transform_RotatePlus90.Size = new Size(180, 22);
            ImageMenu_Transform_RotatePlus90.Text = "Rotate +90°";
            ImageMenu_Transform_RotatePlus90.Click += rotatePlus90ToolStripMenuItem_Click;
            // 
            // ImageMenu_Transform_RotateMinus90
            // 
            ImageMenu_Transform_RotateMinus90.Name = "ImageMenu_Transform_RotateMinus90";
            ImageMenu_Transform_RotateMinus90.Size = new Size(180, 22);
            ImageMenu_Transform_RotateMinus90.Text = "Rotate -90°";
            ImageMenu_Transform_RotateMinus90.Click += rotateMinus90ToolStripMenuItem1_Click;
            // 
            // AnimationMenu
            // 
            AnimationMenu.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_CombineGIFFrames, AnimationMenu_ExportGIFFrames, AnimationMenu_ModifyGIFFrameDelay });
            AnimationMenu.Name = "AnimationMenu";
            AnimationMenu.Size = new Size(75, 20);
            AnimationMenu.Text = "Animation";
            // 
            // AnimationMenu_CombineGIFFrames
            // 
            AnimationMenu_CombineGIFFrames.Name = "AnimationMenu_CombineGIFFrames";
            AnimationMenu_CombineGIFFrames.Size = new Size(200, 22);
            AnimationMenu_CombineGIFFrames.Text = "Combine GIF Frames";
            AnimationMenu_CombineGIFFrames.Click += CombineFramesMenuFrameStrip_Click;
            // 
            // AnimationMenu_ExportGIFFrames
            // 
            AnimationMenu_ExportGIFFrames.Name = "AnimationMenu_ExportGIFFrames";
            AnimationMenu_ExportGIFFrames.Size = new Size(200, 22);
            AnimationMenu_ExportGIFFrames.Text = "Export GIF Frames";
            AnimationMenu_ExportGIFFrames.Click += exportFramesToolStripMenuItem_Click;
            // 
            // AnimationMenu_ModifyGIFFrameDelay
            // 
            AnimationMenu_ModifyGIFFrameDelay.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_ModifyGIFFrameDelay_Textbox });
            AnimationMenu_ModifyGIFFrameDelay.Name = "AnimationMenu_ModifyGIFFrameDelay";
            AnimationMenu_ModifyGIFFrameDelay.Size = new Size(200, 22);
            AnimationMenu_ModifyGIFFrameDelay.Text = "Modify GIF Frame Delay";
            // 
            // AnimationMenu_ModifyGIFFrameDelay_Textbox
            // 
            AnimationMenu_ModifyGIFFrameDelay_Textbox.Name = "AnimationMenu_ModifyGIFFrameDelay_Textbox";
            AnimationMenu_ModifyGIFFrameDelay_Textbox.Size = new Size(100, 23);
            AnimationMenu_ModifyGIFFrameDelay_Textbox.Text = "4";
            // 
            // ColorsMenu
            // 
            ColorsMenu.DropDownItems.AddRange(new ToolStripItem[] { ColorsMenu_ColorShift });
            ColorsMenu.Name = "ColorsMenu";
            ColorsMenu.Size = new Size(53, 20);
            ColorsMenu.Text = "Colors";
            // 
            // ColorsMenu_ColorShift
            // 
            ColorsMenu_ColorShift.Name = "ColorsMenu_ColorShift";
            ColorsMenu_ColorShift.Size = new Size(180, 22);
            ColorsMenu_ColorShift.Text = "Color Shift";
            ColorsMenu_ColorShift.ToolTipText = "Replaces all instances of a color in an image with a new color.";
            ColorsMenu_ColorShift.Click += ColorsMenu_ColorShift_Click;
            // 
            // ViewPort
            // 
            ViewPort.BackColor = Color.FromArgb(224, 224, 224);
            ViewPort.BackgroundImageLayout = ImageLayout.Center;
            ViewPort.BorderStyle = BorderStyle.FixedSingle;
            ViewPort.Location = new Point(3, 3);
            ViewPort.Name = "ViewPort";
            ViewPort.Size = new Size(840, 640);
            ViewPort.SizeMode = PictureBoxSizeMode.Zoom;
            ViewPort.TabIndex = 11;
            ViewPort.TabStop = false;
            // 
            // ViewPortPanel
            // 
            ViewPortPanel.AutoScroll = true;
            ViewPortPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ViewPortPanel.Controls.Add(ViewPort);
            ViewPortPanel.Location = new Point(12, 27);
            ViewPortPanel.Name = "ViewPortPanel";
            ViewPortPanel.Size = new Size(840, 640);
            ViewPortPanel.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 674);
            Controls.Add(ViewPortPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Processor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ViewPortPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem FileMenu_Open;
        private ToolStripMenuItem FileMenu_Quit;
        private ToolStripMenuItem ImageMenu;
        private ToolStripMenuItem ImageMenu_Transform;
        private ToolStripMenuItem ImageMenu_Transform_FlipHorizontally;
        private ToolStripMenuItem ImageMenu_Transform_FlipVertically;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ImageMenu_Transform_RotateMinus90;
        private ToolStripMenuItem ImageMenu_Grayscale;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem FileMenu_SaveAs;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ImageMenu_Transform_RotatePlus90;
        private PictureBox ViewPort;
        private ToolStripMenuItem AnimationMenu;
        private ToolStripMenuItem AnimationMenu_ExportGIFFrames;
        private ToolStripMenuItem ImageMenu_Negative;
        private ToolStripMenuItem ImageMenu_IncreaseBrightness;
        private ToolStripMenuItem ImageMenu_DecreaseBrightness;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private BindingSource bindingSource1;
        private ToolStripMenuItem AnimationMenu_CombineGIFFrames;
        private ToolStripMenuItem AnimationMenu_ModifyGIFFrameDelay;
        private ToolStripTextBox AnimationMenu_ModifyGIFFrameDelay_Textbox;
        private Panel ViewPortPanel;
        private ToolStripMenuItem ColorsMenu;
        private ToolStripMenuItem ColorsMenu_ColorShift;
    }
}