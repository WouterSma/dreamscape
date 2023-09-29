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
            texItemName = new Label();
            texItemDescription = new Label();
            panSelectedItem = new Panel();
            groSelectedItemStats = new GroupBox();
            labSelectedItemType = new Label();
            labSelectedItemMagic = new Label();
            labSelectedItemDurability = new Label();
            labSelectedItemSpeed = new Label();
            labSelectedItemPower = new Label();
            labSelectedItemRarity = new Label();
            labSelectedItemMagicLabel = new Label();
            labSelectedItemDurabilityLabel = new Label();
            labSelectedItemSpeedLabel = new Label();
            labSelectedItemRarityLabel = new Label();
            labSelectedItemPowerLabel = new Label();
            labSelectedItemTypeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)picSelectedItem).BeginInit();
            panSelectedItem.SuspendLayout();
            groSelectedItemStats.SuspendLayout();
            SuspendLayout();
            // 
            // picSelectedItem
            // 
            picSelectedItem.BorderStyle = BorderStyle.FixedSingle;
            picSelectedItem.Location = new Point(15, 15);
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
            // texItemName
            // 
            texItemName.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            texItemName.Location = new Point(899, 365);
            texItemName.Name = "texItemName";
            texItemName.Size = new Size(240, 50);
            texItemName.TabIndex = 2;
            texItemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texItemDescription
            // 
            texItemDescription.Font = new Font("Courier New", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            texItemDescription.Location = new Point(865, 415);
            texItemDescription.MaximumSize = new Size(320, 60);
            texItemDescription.Name = "texItemDescription";
            texItemDescription.Size = new Size(320, 60);
            texItemDescription.TabIndex = 3;
            texItemDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panSelectedItem
            // 
            panSelectedItem.Controls.Add(picSelectedItem);
            panSelectedItem.Location = new Point(850, 12);
            panSelectedItem.Name = "panSelectedItem";
            panSelectedItem.Size = new Size(350, 350);
            panSelectedItem.TabIndex = 6;
            // 
            // groSelectedItemStats
            // 
            groSelectedItemStats.Controls.Add(labSelectedItemType);
            groSelectedItemStats.Controls.Add(labSelectedItemMagic);
            groSelectedItemStats.Controls.Add(labSelectedItemDurability);
            groSelectedItemStats.Controls.Add(labSelectedItemSpeed);
            groSelectedItemStats.Controls.Add(labSelectedItemPower);
            groSelectedItemStats.Controls.Add(labSelectedItemRarity);
            groSelectedItemStats.Controls.Add(labSelectedItemMagicLabel);
            groSelectedItemStats.Controls.Add(labSelectedItemDurabilityLabel);
            groSelectedItemStats.Controls.Add(labSelectedItemSpeedLabel);
            groSelectedItemStats.Controls.Add(labSelectedItemRarityLabel);
            groSelectedItemStats.Controls.Add(labSelectedItemPowerLabel);
            groSelectedItemStats.Controls.Add(labSelectedItemTypeLabel);
            groSelectedItemStats.Location = new Point(865, 478);
            groSelectedItemStats.Name = "groSelectedItemStats";
            groSelectedItemStats.Size = new Size(320, 96);
            groSelectedItemStats.TabIndex = 7;
            groSelectedItemStats.TabStop = false;
            groSelectedItemStats.Text = "STATS";
            // 
            // labSelectedItemType
            // 
            labSelectedItemType.AutoSize = true;
            labSelectedItemType.Location = new Point(202, 23);
            labSelectedItemType.Name = "labSelectedItemType";
            labSelectedItemType.Size = new Size(0, 20);
            labSelectedItemType.TabIndex = 11;
            // 
            // labSelectedItemMagic
            // 
            labSelectedItemMagic.AutoSize = true;
            labSelectedItemMagic.Location = new Point(202, 63);
            labSelectedItemMagic.Name = "labSelectedItemMagic";
            labSelectedItemMagic.Size = new Size(0, 20);
            labSelectedItemMagic.TabIndex = 10;
            // 
            // labSelectedItemDurability
            // 
            labSelectedItemDurability.AutoSize = true;
            labSelectedItemDurability.Location = new Point(202, 43);
            labSelectedItemDurability.Name = "labSelectedItemDurability";
            labSelectedItemDurability.Size = new Size(0, 20);
            labSelectedItemDurability.TabIndex = 9;
            // 
            // labSelectedItemSpeed
            // 
            labSelectedItemSpeed.AutoSize = true;
            labSelectedItemSpeed.Location = new Point(49, 63);
            labSelectedItemSpeed.Name = "labSelectedItemSpeed";
            labSelectedItemSpeed.Size = new Size(0, 20);
            labSelectedItemSpeed.TabIndex = 8;
            // 
            // labSelectedItemPower
            // 
            labSelectedItemPower.AutoSize = true;
            labSelectedItemPower.Location = new Point(49, 43);
            labSelectedItemPower.Name = "labSelectedItemPower";
            labSelectedItemPower.Size = new Size(0, 20);
            labSelectedItemPower.TabIndex = 7;
            // 
            // labSelectedItemRarity
            // 
            labSelectedItemRarity.AutoSize = true;
            labSelectedItemRarity.Location = new Point(49, 23);
            labSelectedItemRarity.Name = "labSelectedItemRarity";
            labSelectedItemRarity.Size = new Size(0, 20);
            labSelectedItemRarity.TabIndex = 6;
            // 
            // labSelectedItemMagicLabel
            // 
            labSelectedItemMagicLabel.AutoSize = true;
            labSelectedItemMagicLabel.Location = new Point(157, 63);
            labSelectedItemMagicLabel.Name = "labSelectedItemMagicLabel";
            labSelectedItemMagicLabel.Size = new Size(42, 20);
            labSelectedItemMagicLabel.TabIndex = 5;
            labSelectedItemMagicLabel.Text = "MAG";
            // 
            // labSelectedItemDurabilityLabel
            // 
            labSelectedItemDurabilityLabel.AutoSize = true;
            labSelectedItemDurabilityLabel.Location = new Point(157, 43);
            labSelectedItemDurabilityLabel.Name = "labSelectedItemDurabilityLabel";
            labSelectedItemDurabilityLabel.Size = new Size(39, 20);
            labSelectedItemDurabilityLabel.TabIndex = 4;
            labSelectedItemDurabilityLabel.Text = "DUR";
            // 
            // labSelectedItemSpeedLabel
            // 
            labSelectedItemSpeedLabel.AutoSize = true;
            labSelectedItemSpeedLabel.Location = new Point(6, 63);
            labSelectedItemSpeedLabel.Name = "labSelectedItemSpeedLabel";
            labSelectedItemSpeedLabel.Size = new Size(36, 20);
            labSelectedItemSpeedLabel.TabIndex = 3;
            labSelectedItemSpeedLabel.Text = "SPD";
            // 
            // labSelectedItemRarityLabel
            // 
            labSelectedItemRarityLabel.AutoSize = true;
            labSelectedItemRarityLabel.Location = new Point(6, 23);
            labSelectedItemRarityLabel.Name = "labSelectedItemRarityLabel";
            labSelectedItemRarityLabel.Size = new Size(37, 20);
            labSelectedItemRarityLabel.TabIndex = 0;
            labSelectedItemRarityLabel.Text = "RAR";
            // 
            // labSelectedItemPowerLabel
            // 
            labSelectedItemPowerLabel.AutoSize = true;
            labSelectedItemPowerLabel.Location = new Point(6, 43);
            labSelectedItemPowerLabel.Name = "labSelectedItemPowerLabel";
            labSelectedItemPowerLabel.Size = new Size(40, 20);
            labSelectedItemPowerLabel.TabIndex = 2;
            labSelectedItemPowerLabel.Text = "PWR";
            // 
            // labSelectedItemTypeLabel
            // 
            labSelectedItemTypeLabel.AutoSize = true;
            labSelectedItemTypeLabel.Location = new Point(157, 23);
            labSelectedItemTypeLabel.Name = "labSelectedItemTypeLabel";
            labSelectedItemTypeLabel.Size = new Size(33, 20);
            labSelectedItemTypeLabel.TabIndex = 1;
            labSelectedItemTypeLabel.Text = "TYP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(groSelectedItemStats);
            Controls.Add(panSelectedItem);
            Controls.Add(texItemDescription);
            Controls.Add(texItemName);
            Controls.Add(tabImages);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picSelectedItem).EndInit();
            panSelectedItem.ResumeLayout(false);
            groSelectedItemStats.ResumeLayout(false);
            groSelectedItemStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picSelectedItem;
        private TableLayoutPanel tabImages;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label texItemName;
        private Label texItemDescription;
        private Panel panSelectedItem;
        private GroupBox groSelectedItemStats;
        private Label labSelectedItemRarityLabel;
        private Label labSelectedItemTypeLabel;
        private Label labSelectedItemRarity;
        private Label labSelectedItemMagicLabel;
        private Label labSelectedItemDurabilityLabel;
        private Label labSelectedItemSpeedLabel;
        private Label labSelectedItemPowerLabel;
        private Label labSelectedItemType;
        private Label labSelectedItemMagic;
        private Label labSelectedItemDurability;
        private Label labSelectedItemSpeed;
        private Label labSelectedItemPower;
    }
}
