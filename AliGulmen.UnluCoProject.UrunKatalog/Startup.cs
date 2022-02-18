using AliGulmen.UnluCoProject.UrunKatalog.Core;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;
using AliGulmen.UnluCoProject.UrunKatalog.Extensions;
using AliGulmen.UnluCoProject.UrunKatalog.Persistence;
using AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories;
using AliGulmen.UnluCoProject.UrunKatalog.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using System.Text;

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
           services.AddScoped<IColorRepository, ColorRepository>();
           services.AddScoped<IUserRepository, UserRepository>();
           services.AddScoped<IOfferRepository, OfferRepository>();
           services.AddScoped<IProductRepository, ProductRepository>();
           services.AddScoped<IPurchaseHistoryRepository, PurchaseHistoryRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddControllers();

            services.AddAuthentication(
               options =>
               {
                   options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                   options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                   options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
               }
               )
               //Adding JWT Bearer
               .AddJwtBearer(
                 options =>
                 {
                     options.SaveToken = true;
                     options.TokenValidationParameters = new TokenValidationParameters
                     {
                         ValidateAudience = true,                       //will it check audience?
                         ValidAudience = Configuration["Jwt:Audience"], //appsettings.json > Jwt > Audience
                         ValidateIssuer = true,                         //will it check issuer?
                         ValidIssuer = Configuration["Jwt:Issuer"],     //appsettings.json > Jwt > Issuer
                         ValidateLifetime = true,                       //we will define different life times for different tokens. Not here.
                         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])),
                         ClockSkew = TimeSpan.Zero

                     };


                 }
                 );

            services.AddScoped<TokenGenerator>();

            services.AddDefaultIdentity<AppUser>(opt => 
            { 
                opt.SignIn.RequireConfirmedAccount = true;
                opt.Password.RequiredLength = 8;
                opt.Lockout.AllowedForNewUsers = true;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(24);
                opt.Lockout.MaxFailedAccessAttempts = 3;

            }
                                   )
                .AddEntityFrameworkStores<UrunKatalogDbContext>();

            

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
            //for JWT
            app.UseAuthentication();


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
