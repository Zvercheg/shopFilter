using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using shoooooop.Data;
using shoooooop.Data.mocks;
using shoooooop.Data.models;
using shoooooop.Data.Repository;
using shoooooop.Interfaces;

namespace shoooooop
{
    public class Startup
    {

        private IConfigurationRoot _confsting;

        public Startup(IHostingEnvironment hostEnv)
        {
            _confsting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //регистрация плагинов
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confsting.GetConnectionString("DefaultConnection")));
            services.AddTransient<iAllCars, CarRepository>();
            services.AddTransient<iCarsCategory, CategoryRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

      
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSession();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles(); //статические файлы типо картинок
           //app.UseMvcWithDefaultRoute(); //отслеживать ирл адресс который вызывает контролер по умолчанию.
            app.UseMvc(routes => {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Car/{action}/{category?}", defaults: new { Controller = "Car", action = "List" });
            });
            
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }

            
        }
    }
}
