using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using MoviesStore.Data;
using MoviesStore.Data.Services;

namespace MoviesStore
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
            // Set the connection string of the app
            services.AddDbContext<MovieStoreDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));

            // Services Configuration
            // Add the Interface and it's service that implements it
            services.AddScoped<IActorsService, ActorsService>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Shared/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action/Index}/{id?}"
                    );
            });

            // Seed data
            MovieStoreDBInitializer.SeedData(app);
        }
    }
}
