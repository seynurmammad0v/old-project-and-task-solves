using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvTapsiriqiFrontToBack.DAL;
using EvTapsiriqiFrontToBack.Helpers;
using EvTapsiriqiFrontToBack.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EvTapsiriqiFrontToBack
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
            });
            services.AddIdentity<AppUser, IdentityRole>(IdentityOption =>
            {
                IdentityOption.Password.RequiredLength = 8;
                IdentityOption.Password.RequireDigit = true;
                IdentityOption.Password.RequireUppercase = false;
                IdentityOption.Password.RequireLowercase = true;
                IdentityOption.Password.RequireNonAlphanumeric = false;

                IdentityOption.User.RequireUniqueEmail = true;

                IdentityOption.Lockout.MaxFailedAccessAttempts = 3;
                IdentityOption.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
                IdentityOption.Lockout.AllowedForNewUsers = true;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders().AddErrorDescriber<CustomIdentityErrorDescriber>();
            services.ConfigureApplicationCookie(options => options.LoginPath = "/account/");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes => {
                routes.MapRoute(            
                  name: "areas",
                  template: "{area:exists}/{controller=dashboard}/{action=index}/{id?}"
              );
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}"
                    );
            });
        }
    }
}
