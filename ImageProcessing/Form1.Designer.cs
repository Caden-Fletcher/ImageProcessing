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
            ((System.ComponentModel.ISupportInitialize)PictureUnaltered).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureAltered).BeginInit();
            SuspendLayout();
            // 
            // PictureUnaltered
            // 
            PictureUnaltered.BackColor = SystemColors.AppWorkspace;
            PictureUnaltered.Location = new Point(12, 12);
            PictureUnaltered.Name = "PictureUnaltered";
            PictureUnaltered.Size = new Size(400, 400);
            PictureUnaltered.TabIndex = 0;
            PictureUnaltered.TabStop = false;
            // 
            // PictureAltered
            // 
            PictureAltered.BackColor = SystemColors.AppWorkspace;
            PictureAltered.Location = new Point(418, 12);
            PictureAltered.Name = "PictureAltered";
            PictureAltered.Size = new Size(400, 400);
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
            viewFrames.BackColor = SystemColors.AppWorkspace;
            viewFrames.Location = new Point(824, 12);
            viewFrames.Name = "viewFrames";
            viewFrames.Size = new Size(200, 400);
            viewFrames.TabIndex = 5;
            viewFrames.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 477);
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
        }

        #endregion

        private PictureBox PictureUnaltered;
        private PictureBox PictureAltered;
        private Button ButtonImport;
        private Button ButtonConvertToGrayscale;
        private Button ButtonExport;
        private ListView viewFrames;
    }
}