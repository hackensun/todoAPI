using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace todoAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                    .UseStartup<TodoApi.Startup>();//add TodoApi before Startup
        }
    }


}
