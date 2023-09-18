namespace DreamScape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            tabImages = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(514, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabImages
            // 
            tabImages.ColumnCount = 5;
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.Location = new Point(48, 47);
            tabImages.Name = "tabImages";
            tabImages.RowCount = 10;
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabImages.Size = new Size(300, 500);
            tabImages.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(tabImages);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tabImages;
    }
}
