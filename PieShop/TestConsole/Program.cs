using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace TestConsole
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }
        static void Main(string[] args)
        {
            // Use the app settings configuration file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // For MVC this would be env.ContentRootPath
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            // Read the string from the appsettings.json file
            Console.WriteLine($"{Configuration["Greeting"]}");
            Console.ReadKey(true);
        }
    }
}