namespace Monopoly
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.IdentityModel.Logging;
    using Microsoft.OpenApi.Models;
    using Monopoly.Core.Options;
    using Monopoly.DAL;
    using Monopoly.DAL.Entities;
    using Monopoly.DAL.Managers;
    using Monopoly.Filters.ActionFilters;
    using Monopoly.Filters.ExceptionFilters;

    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            this.Configuration = configuration;
            this.Env = env;
        }

        public IWebHostEnvironment Env { get; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            IdentityModelEventSource.ShowPII = true;
            this.InstallFilters(services);
            this.InstallBussinessLogic(services);
            this.InstallDataAccess(services);
            this.InstallSwagger(services);

            services.AddMvc().ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            try
            {
                var swaggerOptions = new SwaggerOptions();
                this.Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);
                app.UseSwagger();
                app.UseSwaggerUI(s =>
                {
                    s.SwaggerEndpoint(swaggerOptions.JsonRoute, swaggerOptions.Description);
                    s.RoutePrefix = "swagger";
                });
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
        }

        private void InstallFilters(IServiceCollection services)
        {
            services.AddScoped<MonopolyExceptionFilterAttribute>();
            services.AddScoped<ModelValidationAttribute>();
        }

        private void InstallSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v0", new OpenApiInfo { Version = "v0", Title = "Monopoly API" });
            });
        }

        private void InstallBussinessLogic(IServiceCollection services)
        {
            services.AddScoped<UserManager>();
        }

        private void InstallDataAccess(IServiceCollection services)
        {
            string connection;
            if (!this.Env.IsDevelopment())
            {
                Console.WriteLine("Database in prod mode");
                connection = this.Configuration.GetConnectionString("DefaultConnectionProd");
            }
            else
            {
                Console.WriteLine("Database in dev mode");
                connection = this.Configuration.GetConnectionString("DefaultConnectionProd");
            }

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(connection);
            });
            services.AddIdentityCore<User>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>();

            services.BuildServiceProvider().GetService<AppDbContext>().Database.Migrate(); 
        }
    }
}