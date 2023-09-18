using DreamScape.Models;

namespace DreamScape
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static AppDbContext dbContext;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using (var context = new AppDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
            dbContext = new AppDbContext();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }


    }
}
