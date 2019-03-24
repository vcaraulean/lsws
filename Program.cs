
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace lsws
{
    class Program
    {
        static void Main(string[] args)
        {
            WebHost
                .CreateDefaultBuilder(args)
                .Configure(config => config.UseStaticFiles())
                .UseWebRoot(Directory.GetCurrentDirectory()).Build()
                .Run();
        }
    }
}
