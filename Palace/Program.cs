using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Palace.Models;
using Microsoft.EntityFrameworkCore;

namespace Palace
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      builder.Services.AddDbContext<PalaceContext>(
                        dbContextOptions => dbContextOptions
                          .UseMySql(
                            builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                          )
                        )
                      );

      WebApplication app = builder.Build();

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
    }
  }
}