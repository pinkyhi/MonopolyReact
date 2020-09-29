namespace Monopoly
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.OpenApi.Models;
    using Monopoly.Core.Options;
    using Monopoly.Filters.ActionFilters;
    using Monopoly.Filters.ExceptionFilters;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            this.InstallFilters(services);
            this.InstallSwagger(services);
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
    }
}