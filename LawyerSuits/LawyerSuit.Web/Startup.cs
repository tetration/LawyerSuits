using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LawyerSuits.DAL;
using Microsoft.AspNetCore.Http;
using LawyerSuits.Services.EmailService;

namespace LawyerSuits.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddHttpContextAccessor();
            //var connection = Configuration["ConnectionStrings:SqliteConnectionString"];
            //var connection = Configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<LawyerSuitsDbContext>(options => options.UseSqlite("SqliteConnectionString", mig => mig.MigrationsAssembly("LawyerSuits.DAL")));
            //services.AddDbContext<LawyerSuitsDbContext>(options => options.UseSqlite(Configuration.GetConnectionString(connection), mig => mig.MigrationsAssembly("LawyerSuits.DAL")));
            //services.AddDbContext<LawyerSuitsDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"), mig=> mig.MigrationsAssembly("LawyerSuits.DAL")));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IEmailService, EmailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
