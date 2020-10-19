using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AssistPurchaseBackend
{
    public abstract class Program
    {
        private static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
