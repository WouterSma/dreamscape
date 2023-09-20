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
            picSelectedItem = new PictureBox();
            tabImages = new TableLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)picSelectedItem).BeginInit();
            SuspendLayout();
            // 
            // picSelectedItem
            // 
            picSelectedItem.BorderStyle = BorderStyle.Fixed3D;
            picSelectedItem.Location = new Point(850, 12);
            picSelectedItem.Name = "picSelectedItem";
            picSelectedItem.Size = new Size(320, 320);
            picSelectedItem.SizeMode = PictureBoxSizeMode.StretchImage;
            picSelectedItem.TabIndex = 0;
            picSelectedItem.TabStop = false;
            // 
            // tabImages
            // 
            tabImages.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tabImages.ColumnCount = 5;
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tabImages.Location = new Point(414, 12);
            tabImages.Margin = new Padding(0);
            tabImages.Name = "tabImages";
            tabImages.RowCount = 6;
            tabImages.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tabImages.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tabImages.Size = new Size(400, 480);
            tabImages.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(picSelectedItem);
            Controls.Add(tabImages);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picSelectedItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picSelectedItem;
        private TableLayoutPanel tabImages;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
