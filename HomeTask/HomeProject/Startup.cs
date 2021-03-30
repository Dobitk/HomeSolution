using HomeProject.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace HomeProject
{
    public class Startup
    {
        public IConfiguration _configuration { get; }
        public Startup (IConfiguration configuration)
        {
            _configuration = configuration;

        }
           
         public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddTransient<IEmployeeItems, EFEmployeeItems>();
            services.AddTransient<IFamilyItems, EFFamilyItems>();
            services.AddTransient<IWorkHistoryItems, EFWorkHistoryItems>();
            services.AddTransient<AllManager>();


            _configuration.Bind("TaskProject", new Config());
            
            services.AddDbContext<TasksDBContext>(options => options.UseSqlServer(Config.ConnectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                     endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
             
            });
        }
    }
}
