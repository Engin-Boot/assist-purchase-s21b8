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

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
