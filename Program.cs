using Autofac;
using Microsoft.AspNetCore;

namespace UserRegistrationForm
{

    public class Program
    {

        public static void Main(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                   .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true).Build();

            CreateHostBuilder(args).Build().Run();
        }
        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                   .UseStartup<Startup>();
    }

    }
