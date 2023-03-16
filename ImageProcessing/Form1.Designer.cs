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
            ButtonBrowse = new Button();
            ButtonConvertToGrayscale = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureUnaltered).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureAltered).BeginInit();
            SuspendLayout();
            // 
            // PictureUnaltered
            // 
            PictureUnaltered.Location = new Point(12, 12);
            PictureUnaltered.Name = "PictureUnaltered";
            PictureUnaltered.Size = new Size(400, 400);
            PictureUnaltered.TabIndex = 0;
            PictureUnaltered.TabStop = false;
            // 
            // PictureAltered
            // 
            PictureAltered.Location = new Point(418, 12);
            PictureAltered.Name = "PictureAltered";
            PictureAltered.Size = new Size(400, 400);
            PictureAltered.TabIndex = 1;
            PictureAltered.TabStop = false;
            // 
            // ButtonBrowse
            // 
            ButtonBrowse.Location = new Point(12, 418);
            ButtonBrowse.Name = "ButtonBrowse";
            ButtonBrowse.Size = new Size(75, 23);
            ButtonBrowse.TabIndex = 2;
            ButtonBrowse.Text = "Browse";
            ButtonBrowse.UseVisualStyleBackColor = true;
            ButtonBrowse.Click += ButtonBrowse_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 469);
            Controls.Add(ButtonConvertToGrayscale);
            Controls.Add(ButtonBrowse);
            Controls.Add(PictureAltered);
            Controls.Add(PictureUnaltered);
            Name = "Form1";
            Text = "Image Processor";
            ((System.ComponentModel.ISupportInitialize)PictureUnaltered).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureAltered).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureUnaltered;
        private PictureBox PictureAltered;
        private Button ButtonBrowse;
        private Button ButtonConvertToGrayscale;
    }
}