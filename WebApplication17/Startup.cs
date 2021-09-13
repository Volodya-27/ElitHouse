using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication17.DataBase;

namespace WebApplication17
{
    public class Startup
    {
        //private IConfigurationRoot configurationRoot;

        //public Startup(IWebHostEnvironment configuration)
        //{
        //    configurationRoot = new ConfigurationBuilder().SetBasePath(configuration.ContentRootPath).AddJsonFile("DataBasesettings1.json").Build(); 
        //}




        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<DataContext>(options => options.UseSqlServer);
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddControllersWithViews(mvcOtions =>
            {
                mvcOtions.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Add}");
            });
        }
    }
}
