﻿namespace ImageProcessing
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            decreaseBrightnessImageMenuStrip = new ToolStripMenuItem();
            increaseBrightnessImageMenuStrip = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            grayscaleToolStripMenuItem = new ToolStripMenuItem();
            negativeMenuImageStrip = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            transformToolStripMenuItem = new ToolStripMenuItem();
            flipHorizontallyToolStripMenuItem = new ToolStripMenuItem();
            flipVerticallyToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            rotatePlus90ToolStripMenuItem = new ToolStripMenuItem();
            rotateMinus90ToolStripMenuItem1 = new ToolStripMenuItem();
            framesToolStripMenuItem = new ToolStripMenuItem();
            CombineFramesMenuFrameStrip = new ToolStripMenuItem();
            exportFramesToolStripMenuItem = new ToolStripMenuItem();
            ViewPort = new PictureBox();
            bindingSource1 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, imageToolStripMenuItem, framesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(853, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator2, saveAsToolStripMenuItem, toolStripSeparator3, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(186, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(183, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(186, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(183, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(186, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { decreaseBrightnessImageMenuStrip, increaseBrightnessImageMenuStrip, toolStripSeparator4, grayscaleToolStripMenuItem, negativeMenuImageStrip, toolStripSeparator5, transformToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(52, 20);
            imageToolStripMenuItem.Text = "Image";
            // 
            // decreaseBrightnessImageMenuStrip
            // 
            decreaseBrightnessImageMenuStrip.Name = "decreaseBrightnessImageMenuStrip";
            decreaseBrightnessImageMenuStrip.Size = new Size(179, 22);
            decreaseBrightnessImageMenuStrip.Text = "Decrease Brightness";
            decreaseBrightnessImageMenuStrip.Click += decreaseBrightnessImageMenuStrip_Click;
            // 
            // increaseBrightnessImageMenuStrip
            // 
            increaseBrightnessImageMenuStrip.Name = "increaseBrightnessImageMenuStrip";
            increaseBrightnessImageMenuStrip.Size = new Size(179, 22);
            increaseBrightnessImageMenuStrip.Text = "Increase Brightness";
            increaseBrightnessImageMenuStrip.Click += increaseBrightnessImageMenuStrip_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(176, 6);
            // 
            // grayscaleToolStripMenuItem
            // 
            grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            grayscaleToolStripMenuItem.Size = new Size(179, 22);
            grayscaleToolStripMenuItem.Text = "Grayscale";
            grayscaleToolStripMenuItem.Click += convertToGrayscaleToolStripMenuItem_Click;
            // 
            // negativeMenuImageStrip
            // 
            negativeMenuImageStrip.Name = "negativeMenuImageStrip";
            negativeMenuImageStrip.Size = new Size(179, 22);
            negativeMenuImageStrip.Text = "Negative";
            negativeMenuImageStrip.Click += convertToNegativeMenuImageStrip_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(176, 6);
            // 
            // transformToolStripMenuItem
            // 
            transformToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { flipHorizontallyToolStripMenuItem, flipVerticallyToolStripMenuItem, toolStripSeparator1, rotatePlus90ToolStripMenuItem, rotateMinus90ToolStripMenuItem1 });
            transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            transformToolStripMenuItem.Size = new Size(179, 22);
            transformToolStripMenuItem.Text = "Transform";
            // 
            // flipHorizontallyToolStripMenuItem
            // 
            flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
            flipHorizontallyToolStripMenuItem.Size = new Size(160, 22);
            flipHorizontallyToolStripMenuItem.Text = "Flip Horizontally";
            flipHorizontallyToolStripMenuItem.Click += flipHorizontallyToolStripMenuItem_Click;
            // 
            // flipVerticallyToolStripMenuItem
            // 
            flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
            flipVerticallyToolStripMenuItem.Size = new Size(160, 22);
            flipVerticallyToolStripMenuItem.Text = "Flip Vertically";
            flipVerticallyToolStripMenuItem.Click += flipVerticallyToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // rotatePlus90ToolStripMenuItem
            // 
            rotatePlus90ToolStripMenuItem.Name = "rotatePlus90ToolStripMenuItem";
            rotatePlus90ToolStripMenuItem.Size = new Size(160, 22);
            rotatePlus90ToolStripMenuItem.Text = "Rotate +90°";
            rotatePlus90ToolStripMenuItem.Click += rotatePlus90ToolStripMenuItem_Click;
            // 
            // rotateMinus90ToolStripMenuItem1
            // 
            rotateMinus90ToolStripMenuItem1.Name = "rotateMinus90ToolStripMenuItem1";
            rotateMinus90ToolStripMenuItem1.Size = new Size(160, 22);
            rotateMinus90ToolStripMenuItem1.Text = "Rotate -90°";
            rotateMinus90ToolStripMenuItem1.Click += rotateMinus90ToolStripMenuItem1_Click;
            // 
            // framesToolStripMenuItem
            // 
            framesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CombineFramesMenuFrameStrip, exportFramesToolStripMenuItem });
            framesToolStripMenuItem.Name = "framesToolStripMenuItem";
            framesToolStripMenuItem.Size = new Size(57, 20);
            framesToolStripMenuItem.Text = "Frames";
            // 
            // CombineFramesMenuFrameStrip
            // 
            CombineFramesMenuFrameStrip.Name = "CombineFramesMenuFrameStrip";
            CombineFramesMenuFrameStrip.Size = new Size(164, 22);
            CombineFramesMenuFrameStrip.Text = "Combine Frames";
            CombineFramesMenuFrameStrip.Click += CombineFramesMenuFrameStrip_Click;
            // 
            // exportFramesToolStripMenuItem
            // 
            exportFramesToolStripMenuItem.Name = "exportFramesToolStripMenuItem";
            exportFramesToolStripMenuItem.Size = new Size(164, 22);
            exportFramesToolStripMenuItem.Text = "Export Frames";
            exportFramesToolStripMenuItem.Click += exportFramesToolStripMenuItem_Click;
            // 
            // ViewPort
            // 
            ViewPort.BackColor = Color.FromArgb(224, 224, 224);
            ViewPort.BackgroundImageLayout = ImageLayout.Center;
            ViewPort.BorderStyle = BorderStyle.FixedSingle;
            ViewPort.Location = new Point(12, 27);
            ViewPort.Name = "ViewPort";
            ViewPort.Size = new Size(827, 627);
            ViewPort.SizeMode = PictureBoxSizeMode.Zoom;
            ViewPort.TabIndex = 11;
            ViewPort.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 666);
            Controls.Add(ViewPort);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Processor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem transformToolStripMenuItem;
        private ToolStripMenuItem flipHorizontallyToolStripMenuItem;
        private ToolStripMenuItem flipVerticallyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem rotateMinus90ToolStripMenuItem1;
        private ToolStripMenuItem grayscaleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem rotatePlus90ToolStripMenuItem;
        private PictureBox ViewPort;
        private ToolStripMenuItem framesToolStripMenuItem;
        private ToolStripMenuItem exportFramesToolStripMenuItem;
        private ToolStripMenuItem negativeMenuImageStrip;
        private ToolStripMenuItem increaseBrightnessImageMenuStrip;
        private ToolStripMenuItem decreaseBrightnessImageMenuStrip;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private BindingSource bindingSource1;
        private ToolStripMenuItem CombineFramesMenuFrameStrip;
    }
}