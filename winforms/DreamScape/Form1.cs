using DreamScape.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
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

                    PictureBox pictureBox = new PictureBox
                    {
                        ImageLocation = imagePath,
                        SizeMode = PictureBoxSizeMode.Zoom,  // or another mode you prefer
                        Dock = DockStyle.Fill,
                        Padding = new Padding(5)  // Optional, for some space around images
                    };
                    System.Diagnostics.Debug.WriteLine(item.Name);
                    tabImages.Controls.Add(pictureBox);
                }
            }
        }

        private void LoadItemsFromDatabase()
        {
            try
            {
                items = Program.dbContext.Items.ToList();
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
    }
}
