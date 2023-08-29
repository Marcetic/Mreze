using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BankaProjekat.IRepositories;
using BankaProjekat.Repositories;
using Microsoft.AspNetCore.Http;
using BankaProjekat.Data;
using Microsoft.EntityFrameworkCore;

namespace BankaProjekat
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSession();

            // Registracija repozitorijuma kao servisa
            services.AddScoped<IBankaRepository, BankaRepository>();
            services.AddScoped<IFilijalaRepository, FilijalaRepository>();
            services.AddScoped<IKorisnikRepository, KorisnikRepository>();
            services.AddScoped<IUslugaRepository, UslugaRepository>();

            services.AddDbContext<BankaDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DBContextConnection"));
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();

            app.Use(async (context, next) =>
            {
                if (string.IsNullOrEmpty(context.Session.GetString("Role")))
                {
                    context.Session.SetString("Role", "guest");
                }
              
              


                await next.Invoke();
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Register}/{action=RegisterUser}/{id?}");
            });
        }
    }
}