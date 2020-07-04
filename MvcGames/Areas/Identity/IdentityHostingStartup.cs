using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcGames.Areas.Identity.Data;
using MvcGames.Data;

[assembly: HostingStartup(typeof(MvcGames.Areas.Identity.IdentityHostingStartup))]
namespace MvcGames.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MvcGamesIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MvcGamesIdentityContextConnection")));

                services.AddDefaultIdentity<MvcGamesUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MvcGamesIdentityContext>();
            });
        }
    }
}