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
            ((System.ComponentModel.ISupportInitialize)PictureUnaltered).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureAltered).BeginInit();
            SuspendLayout();
            // 
            // PictureUnaltered
            // 
            PictureUnaltered.BackColor = Color.FromArgb(224, 224, 224);
            PictureUnaltered.BorderStyle = BorderStyle.FixedSingle;
            PictureUnaltered.Location = new Point(12, 12);
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
            PictureAltered.Location = new Point(418, 12);
            PictureAltered.Name = "PictureAltered";
            PictureAltered.Size = new Size(400, 400);
            PictureAltered.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureAltered.TabIndex = 1;
            PictureAltered.TabStop = false;
            // 
            // ButtonImport
            // 
            ButtonImport.Location = new Point(12, 418);
            ButtonImport.Name = "ButtonImport";
            ButtonImport.Size = new Size(75, 23);
            ButtonImport.TabIndex = 2;
            ButtonImport.Text = "Import";
            ButtonImport.UseVisualStyleBackColor = true;
            ButtonImport.Click += ButtonImport_Click;
            // 
            // ButtonConvertToGrayscale
            // 
            ButtonConvertToGrayscale.Location = new Point(418, 418);
            ButtonConvertToGrayscale.Name = "ButtonConvertToGrayscale";
            ButtonConvertToGrayscale.Size = new Size(139, 23);
            ButtonConvertToGrayscale.TabIndex = 3;
            ButtonConvertToGrayscale.Text = "Convert To Grayscale";
            ButtonConvertToGrayscale.UseVisualStyleBackColor = true;
            ButtonConvertToGrayscale.Click += ButtonConvertToGrayscale_Click;
            // 
            // ButtonExport
            // 
            ButtonExport.Location = new Point(418, 447);
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
            viewFrames.Location = new Point(824, 12);
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
            labelFrames.Location = new Point(824, 418);
            labelFrames.Name = "labelFrames";
            labelFrames.Size = new Size(77, 21);
            labelFrames.TabIndex = 6;
            labelFrames.Text = "Frames: 0";
            // 
            // buttonRetrieveFrames
            // 
            buttonRetrieveFrames.Location = new Point(824, 447);
            buttonRetrieveFrames.Name = "buttonRetrieveFrames";
            buttonRetrieveFrames.Size = new Size(139, 23);
            buttonRetrieveFrames.TabIndex = 7;
            buttonRetrieveFrames.Text = "Retrieve Frames";
            buttonRetrieveFrames.UseVisualStyleBackColor = true;
            buttonRetrieveFrames.Click += buttonRetrieveFrames_Click;
            // 
            // buttonClearFrames
            // 
            buttonClearFrames.Location = new Point(824, 476);
            buttonClearFrames.Name = "buttonClearFrames";
            buttonClearFrames.Size = new Size(139, 23);
            buttonClearFrames.TabIndex = 8;
            buttonClearFrames.Text = "Clear Frames";
            buttonClearFrames.UseVisualStyleBackColor = true;
            buttonClearFrames.Click += buttonClearFrames_Click;
            // 
            // buttonExportFrames
            // 
            buttonExportFrames.Location = new Point(824, 505);
            buttonExportFrames.Name = "buttonExportFrames";
            buttonExportFrames.Size = new Size(139, 23);
            buttonExportFrames.TabIndex = 9;
            buttonExportFrames.Text = "Export Frames";
            buttonExportFrames.UseVisualStyleBackColor = true;
            buttonExportFrames.Click += buttonExportFrames_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 535);
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
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Processor";
            ((System.ComponentModel.ISupportInitialize)PictureUnaltered).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureAltered).EndInit();
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
    }
}