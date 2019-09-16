using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using kafer_house.Data;
using kafer_house.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace kafer_house
{
    public class Startup
    {
        // private const string V = "Server=localhost;Database=kafer;User=root;Password=;";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddDbContext<KaferDbContext>(options =>
                 options.UseSqlite(Configuration.GetConnectionString("DataContext")));

            // step three add cookies
            services.AddIdentity<ApplicationUser, ApplicationRole>()   
                // this one is added so usermanager and rolemanager can be used
                .AddEntityFrameworkStores<KaferDbContext>()
                // generate unique key when user forgets password
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;

                // Lockout settings.
                // options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                // options.Lockout.MaxFailedAccessAttempts = 5;
                // options.Lockout.AllowedForNewUsers = true;

                // User settings.
                // options.User.AllowedUserNameCharacters =
                // "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                // options.User.RequireUniqueEmail = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                // step nine cookie expires in ... minutes
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

                // options.LoginPath = "/Identity/Account/Login";
                // options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            //step3: add compatibility to support .net version 2.2
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //step4: add serialization to support linq query with complex data structure
            services.AddMvc().AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            // CultureInfo.CurrentCulture = new CultureInfo("th-TH");

            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
             try
            {
                var context = serviceProvider.GetRequiredService<KaferDbContext>();
                
                CreateRoles(serviceProvider).Wait();

            }
            catch (Exception)
            {
            }

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
            app.UseCookiePolicy();

            // step four
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private async Task CreateRoles(IServiceProvider serviceProvider)
        {

            var RoleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var _context = serviceProvider.GetRequiredService<KaferDbContext>();
            
            
            IdentityResult roleResult;
    
            foreach (string role in Roles.getRoles())
            {
                var roleExist = await RoleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    ApplicationRole add = new ApplicationRole();
                    add.Name = role;
                    roleResult = RoleManager.
                    CreateAsync(add).Result;
                }

            }
            

            bool Owner = (await UserManager.GetUsersInRoleAsync(Roles.Admin)).Where(u => u.UserName == "owner").Any();
            if (!Owner)
            {
                        var newUser = new ApplicationUser
                        {
                            UserName = "owner",
                            FirstName = "John",
                            LastName = "Doe",
                            Email = "DoeDoe@gmail.com",
                        };
            
                        string password = "password";
                        await UserManager.CreateAsync(newUser, password);
                        await UserManager.AddToRoleAsync(newUser, Roles.Owner);
                        
                        newUser.EmailConfirmed = true;
                        await UserManager.UpdateAsync(newUser);
                        
                }
                
            }
    }
}
