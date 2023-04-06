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
            PictureUnaltered = new PictureBox();
            PictureAltered = new PictureBox();
            ButtonImport = new Button();
            ButtonConvertToGrayscale = new Button();
            ButtonExport = new Button();
            viewFrames = new ListView();
            labelFrames = new Label();
            buttonRetrieveFrames = new Button();
            buttonClearFrames = new Button();
            buttonExportFrames = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            convertToGrayscaleToolStripMenuItem = new ToolStripMenuItem();
            transformToolStripMenuItem = new ToolStripMenuItem();
            flipHorizontallyToolStripMenuItem = new ToolStripMenuItem();
            flipVerticallyToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            rotate90ToolStripMenuItem1 = new ToolStripMenuItem();
            rotate90ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)PictureUnaltered).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureAltered).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PictureUnaltered
            // 
            PictureUnaltered.BackColor = Color.FromArgb(224, 224, 224);
            PictureUnaltered.BorderStyle = BorderStyle.FixedSingle;
            PictureUnaltered.Location = new Point(9, 44);
            PictureUnaltered.Name = "PictureUnaltered";
            PictureUnaltered.Size = new Size(400, 400);
            PictureUnaltered.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureUnaltered.TabIndex = 0;
            PictureUnaltered.TabStop = false;
            // 
            // PictureAltered
            // 
            PictureAltered.BackColor = Color.FromArgb(224, 224, 224);
            PictureAltered.BorderStyle = BorderStyle.FixedSingle;
            PictureAltered.Location = new Point(415, 44);
            PictureAltered.Name = "PictureAltered";
            PictureAltered.Size = new Size(400, 400);
            PictureAltered.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureAltered.TabIndex = 1;
            PictureAltered.TabStop = false;
            // 
            // ButtonImport
            // 
            ButtonImport.Location = new Point(9, 450);
            ButtonImport.Name = "ButtonImport";
            ButtonImport.Size = new Size(75, 23);
            ButtonImport.TabIndex = 2;
            ButtonImport.Text = "Import";
            ButtonImport.UseVisualStyleBackColor = true;
            ButtonImport.Click += ButtonImport_Click;
            // 
            // ButtonConvertToGrayscale
            // 
            ButtonConvertToGrayscale.Location = new Point(415, 450);
            ButtonConvertToGrayscale.Name = "ButtonConvertToGrayscale";
            ButtonConvertToGrayscale.Size = new Size(139, 23);
            ButtonConvertToGrayscale.TabIndex = 3;
            ButtonConvertToGrayscale.Text = "Convert To Grayscale";
            ButtonConvertToGrayscale.UseVisualStyleBackColor = true;
            ButtonConvertToGrayscale.Click += ButtonConvertToGrayscale_Click;
            // 
            // ButtonExport
            // 
            ButtonExport.Location = new Point(415, 479);
            ButtonExport.Name = "ButtonExport";
            ButtonExport.Size = new Size(139, 23);
            ButtonExport.TabIndex = 4;
            ButtonExport.Text = "Export";
            ButtonExport.UseVisualStyleBackColor = true;
            ButtonExport.Click += ButtonExport_Click;
            // 
            // viewFrames
            // 
            viewFrames.BackColor = Color.FromArgb(224, 224, 224);
            viewFrames.BorderStyle = BorderStyle.FixedSingle;
            viewFrames.Location = new Point(821, 44);
            viewFrames.Name = "viewFrames";
            viewFrames.Size = new Size(300, 400);
            viewFrames.TabIndex = 5;
            viewFrames.UseCompatibleStateImageBehavior = false;
            viewFrames.SelectedIndexChanged += viewFrames_SelectedIndexChanged;
            // 
            // labelFrames
            // 
            labelFrames.AutoSize = true;
            labelFrames.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFrames.Location = new Point(821, 450);
            labelFrames.Name = "labelFrames";
            labelFrames.Size = new Size(77, 21);
            labelFrames.TabIndex = 6;
            labelFrames.Text = "Frames: 0";
            // 
            // buttonRetrieveFrames
            // 
            buttonRetrieveFrames.Location = new Point(821, 479);
            buttonRetrieveFrames.Name = "buttonRetrieveFrames";
            buttonRetrieveFrames.Size = new Size(139, 23);
            buttonRetrieveFrames.TabIndex = 7;
            buttonRetrieveFrames.Text = "Retrieve Frames";
            buttonRetrieveFrames.UseVisualStyleBackColor = true;
            buttonRetrieveFrames.Click += buttonRetrieveFrames_Click;
            // 
            // buttonClearFrames
            // 
            buttonClearFrames.Location = new Point(821, 508);
            buttonClearFrames.Name = "buttonClearFrames";
            buttonClearFrames.Size = new Size(139, 23);
            buttonClearFrames.TabIndex = 8;
            buttonClearFrames.Text = "Clear Frames";
            buttonClearFrames.UseVisualStyleBackColor = true;
            buttonClearFrames.Click += buttonClearFrames_Click;
            // 
            // buttonExportFrames
            // 
            buttonExportFrames.Location = new Point(821, 537);
            buttonExportFrames.Name = "buttonExportFrames";
            buttonExportFrames.Size = new Size(139, 23);
            buttonExportFrames.TabIndex = 9;
            buttonExportFrames.Text = "Export Frames";
            buttonExportFrames.UseVisualStyleBackColor = true;
            buttonExportFrames.Click += buttonExportFrames_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, imageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1138, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator2, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator3, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(143, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(146, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertToGrayscaleToolStripMenuItem, transformToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(52, 20);
            imageToolStripMenuItem.Text = "Image";
            // 
            // convertToGrayscaleToolStripMenuItem
            // 
            convertToGrayscaleToolStripMenuItem.Name = "convertToGrayscaleToolStripMenuItem";
            convertToGrayscaleToolStripMenuItem.Size = new Size(183, 22);
            convertToGrayscaleToolStripMenuItem.Text = "Convert to Grayscale";
            // 
            // transformToolStripMenuItem
            // 
            transformToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { flipHorizontallyToolStripMenuItem, flipVerticallyToolStripMenuItem, toolStripSeparator1, rotate90ToolStripMenuItem, rotate90ToolStripMenuItem1 });
            transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            transformToolStripMenuItem.Size = new Size(183, 22);
            transformToolStripMenuItem.Text = "Transform";
            // 
            // flipHorizontallyToolStripMenuItem
            // 
            flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
            flipHorizontallyToolStripMenuItem.Size = new Size(180, 22);
            flipHorizontallyToolStripMenuItem.Text = "Flip Horizontally";
            // 
            // flipVerticallyToolStripMenuItem
            // 
            flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
            flipVerticallyToolStripMenuItem.Size = new Size(180, 22);
            flipVerticallyToolStripMenuItem.Text = "Flip Vertically";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // rotate90ToolStripMenuItem1
            // 
            rotate90ToolStripMenuItem1.Name = "rotate90ToolStripMenuItem1";
            rotate90ToolStripMenuItem1.Size = new Size(180, 22);
            rotate90ToolStripMenuItem1.Text = "Rotate -90°";
            // 
            // rotate90ToolStripMenuItem
            // 
            rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            rotate90ToolStripMenuItem.Size = new Size(180, 22);
            rotate90ToolStripMenuItem.Text = "Rotate +90°";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 563);
            Controls.Add(buttonExportFrames);
            Controls.Add(buttonClearFrames);
            Controls.Add(buttonRetrieveFrames);
            Controls.Add(labelFrames);
            Controls.Add(viewFrames);
            Controls.Add(ButtonExport);
            Controls.Add(ButtonConvertToGrayscale);
            Controls.Add(ButtonImport);
            Controls.Add(PictureAltered);
            Controls.Add(PictureUnaltered);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Processor";
            ((System.ComponentModel.ISupportInitialize)PictureUnaltered).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureAltered).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureUnaltered;
        private PictureBox PictureAltered;
        private Button ButtonImport;
        private Button ButtonConvertToGrayscale;
        private Button ButtonExport;
        private ListView viewFrames;
        private Label labelFrames;
        private Button buttonRetrieveFrames;
        private Button buttonClearFrames;
        private Button buttonExportFrames;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem transformToolStripMenuItem;
        private ToolStripMenuItem flipHorizontallyToolStripMenuItem;
        private ToolStripMenuItem flipVerticallyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem rotate90ToolStripMenuItem1;
        private ToolStripMenuItem convertToGrayscaleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem rotate90ToolStripMenuItem;
    }
}