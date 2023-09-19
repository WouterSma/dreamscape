using DreamScape.Models;
using Microsoft.EntityFrameworkCore;
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
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, item.ImagePath);
                    Color rarityColor;
                    if (item.Rarity.HasValue)
                    {
                        int rarityInt = item.Rarity.Value;
                        switch (rarityInt)
                        {
                            case int r when r < 35:
                                rarityColor = Color.LimeGreen;
                                break;
                            case int r when r < 55:
                                rarityColor = Color.DodgerBlue;
                                break;
                            case int r when r < 75:
                                rarityColor = Color.FromArgb(180, 0, 255); // Bright Purple
                                break;
                            case int r when r < 90:
                                rarityColor = Color.Gold;
                                break;
                            case int r when r <= 100:
                                rarityColor = Color.Red;
                                break;
                            default:
                                rarityColor = Color.Gray;
                                break;
                        }
                    } else
                    {
                        rarityColor = Color.Gray;
                    }

                    Panel panel = new Panel
                    {
                        Width = 80,  // or whatever size you want
                        Height = 80,
                        Padding = new Padding(5),  // Optional padding to give space between the image and the border
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = rarityColor
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        ImageLocation = imagePath,
                        SizeMode = PictureBoxSizeMode.Zoom,  // or another mode you prefer
                        Dock = DockStyle.Fill,
                        Padding = new Padding(2),
                        Margin = new Padding(0)
                    };
                    panel.Controls.Add(pictureBox);
                    tabImages.Controls.Add(panel);
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
                Console.WriteLine("An error occurred while fetching items: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images/vlammenzwaard.png");
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
