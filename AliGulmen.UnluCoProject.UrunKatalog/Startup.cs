using AliGulmen.UnluCoProject.UrunKatalog.Core;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;
using AliGulmen.UnluCoProject.UrunKatalog.Extensions;
using AliGulmen.UnluCoProject.UrunKatalog.Persistence;
using AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace AliGulmen.UnluCoProject.UrunKatalog
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
            services.AddDbContext<UrunKatalogDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:Default"]));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
           
           services.AddScoped<ICategoryRepository, CategoryRepository>();
           services.AddScoped<IBrandRepository, BrandRepository>();
           services.AddScoped<IConditionRepository, ConditionRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AliGulmen.UnluCoProject.UrunKatalog", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AliGulmen.UnluCoProject.UrunKatalog v1"));
            }

            app.UseCustomGlobalException();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
