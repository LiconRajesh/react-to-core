using Ardalis.ListStartupServices;
using Autofac;
using Core_To_React_Api.Core;
using Core_To_React_Api.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace Core_To_React_Api.Web
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;

        public Startup(IConfiguration config, IWebHostEnvironment env)
        {
            Configuration = config;
            _env = env;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            string connectionString = Configuration.GetConnectionString("DefaultConnection");  //Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext(connectionString);

            services.AddControllersWithViews().AddNewtonsoftJson();
            services.AddRazorPages();
            services.AddMvc();
            services.AddSwaggerGen();
            services.AddCors();
            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddJsonOptions(jsonOptions =>
            {
                jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "http://localhost:57678/api/Admin/ManageUser", Version = "v1" });
            });


            // add list services for diagnostic purposes - see https://github.com/ardalis/AspNetCoreStartupServices
            services.Configure<ServiceConfig>(config =>
            {
                config.Services = new List<ServiceDescriptor>(services);

                // optional - default path to view services is /listallservices - recommended to choose your own path
                config.Path = "/listservices";
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new DefaultCoreModule());
            builder.RegisterModule(new DefaultInfrastructureModule(_env.EnvironmentName == "Development"));
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.EnvironmentName == "Development")
            {
                app.UseDeveloperExceptionPage();
                app.UseShowAllServicesMiddleware();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseRouting();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin() // You can also specify specific origins here
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "http://localhost:57678/api/Admin/ManageUser"));
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });
        }
    }
}
