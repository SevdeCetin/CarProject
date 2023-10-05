using CarProject.API.Models;
using CarProject.Business.Abstract;
using CarProject.Business.Concrete;
using CarProject.DataAccess.Abstract;
using CarProject.DataAccess.Concrete;
using CarProject.DataAccess.DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.API
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
            var key = Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value);

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
            });

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings:Token"));

            services.AddControllers();
            services.AddDbContext<IhaleDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")/*, x =>x.MigrationsAssembly("YPLayer.DataAccess")*/));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            });
            services.AddScoped<IAuthRepo, AuthRepo>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAracService, AracManager>();
            services.AddScoped<IKullaniciService, KullaniciManager>();

            services.AddSwaggerGen(a =>
            {
                a.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Arac Ihale API", Version = "v1" });

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors();
            app.UseCors(builder => builder.WithOrigins("http://localhost:31207").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(a =>
            {
                a.SwaggerEndpoint("/swagger/v1/swagger.json", "swagger");
            });
        }
    }
}
