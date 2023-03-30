using Invoice.Models.Repository;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Invoice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           
           
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            services.ConfigureService();
            var serviceProvider = services.BuildServiceProvider();
            Application.Run(new Main(serviceProvider));
        }
    }
}