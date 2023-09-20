using DreamScape.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DreamScape
{
    public partial class Form1 : Form
    {
        private List<Item> items;

        public Form1()
        {
            InitializeComponent();
            // Load items from the database
            LoadItemsFromDatabase();

            // Display item names in the console
            foreach (Item item in items)
            {
                if (item.ImagePath != null)
                {
                    // Get the right imagepath from the partial path from the database
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, item.ImagePath);

                    // Select the color for the border based on rarity
                    Color rarityColor;
                    if (item.Rarity.HasValue)
                    {
                        int rarityInt = item.Rarity.Value;
                        switch (rarityInt)
                        {
                            case int r when r < 40:
                                rarityColor = Color.LimeGreen;
                                break;
                            case int r when r < 60:
                                rarityColor = Color.DodgerBlue;
                                break;
                            case int r when r < 80:
                                rarityColor = Color.FromArgb(180, 0, 255); // Bright Purple
                                break;
                            case int r when r < 95:
                                rarityColor = Color.Gold;
                                break;
                            case int r when r <= 100:
                                rarityColor = Color.Red;
                                break;
                            default:
                                rarityColor = Color.Gray;
                                break;
                        }
                    }
                    else
                    {
                        rarityColor = Color.Gray;
                    }

                    // Panel to place the picture in, for the colored border
                    Panel panel = new Panel
                    {
                        Width = 80,
                        Height = 80,
                        Padding = new Padding(5),  // Optional padding to give space between the image and the border
                        Margin = new Padding(0),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = rarityColor
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        ImageLocation = imagePath,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Fill,
                        Padding = new Padding(2),
                        Margin = new Padding(0)
                    };
                    panel.Controls.Add(pictureBox);
                    tabImages.Controls.Add(panel);
                    pictureBox.Click += PictureBox_Click;
                }
            }
        }
        private void LoadItemsFromDatabase()
        {
            try
            {
                items = Program.dbContext.Items.OrderBy(i => i.Rarity).ToList();
            }
            catch (Exception ex)
            {
                // Log or display the error
                Debug.WriteLine("An error occurred while fetching items: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Show the larger image of the selected item
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                picSelectedItem.Image = clickedPictureBox.Image;
                picSelectedItem.BorderStyle = picSelectedItem.BorderStyle;
            }
        }

    }
}
