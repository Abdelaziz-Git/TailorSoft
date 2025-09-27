
using TailorSoft_Business_Layer;
using Microsoft.Extensions.Configuration;
using TailorSoft.Global_Classes;
using TailorSoft_Data_Layer;
using TailorSoft.Customer.Forms;
using TailorSoft;
using TailorSoft.Order.Forms;
using HFS;



namespace TailorSoft
{
    internal static class Program
    {
        // Expose it so any Form or service-factory can grab it.
        public static IConfiguration? Configuration { get; set; }
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings\\appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            clsDatabaseSettings.DefaultConnection = Configuration?.GetSection("ConnectionStrings:DefaultConnection").Value ?? string.Empty;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}