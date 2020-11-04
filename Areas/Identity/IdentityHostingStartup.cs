using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SurveyCo.Areas.Identity.Data;
using SurveyCo.Data;

[assembly: HostingStartup(typeof(SurveyCo.Areas.Identity.IdentityHostingStartup))]
namespace SurveyCo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SurveyCoDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SurveyCoDbContextConnection")));

                services.AddDefaultIdentity<SurveyCoUserModel>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SurveyCoDbContext>();
            });
        }
    }
}