using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CHUSHKA.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CHUSHKA.Services.Contracts;
using CHUSHKA.Services;
using CHUSHKA.Data.Entities;

namespace CHUSHKA
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

            services.AddDbContext<ApplicationDbContext>(options =>
               {
                  // options.UseLazyLoadingProxies();
                   options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection"));
               }
                ) ;

            //services.AddDefaultIdentity<User>(
            //    options =>
            //    options.SignIn.RequireConfirmedAccount = false
            //    )
            //    .AddRoles<IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(options =>
                 options.SignIn.RequireConfirmedEmail = false
                );


            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 1;
            })
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();

           // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services.AddControllersWithViews();

            services.AddRazorPages();
            services.AddMvc(option =>
                    option.EnableEndpointRouting = false);

             

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUsersService, UsersService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            
           // app.UseDatabaseMigration();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseDatabaseMigration();
            //app.UseMvc();

          // app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();


            app.UseMvc(routes =>
            {
               routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}");
             });
                
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //    endpoints.MapRazorPages();
            //});
        }
    }
}
