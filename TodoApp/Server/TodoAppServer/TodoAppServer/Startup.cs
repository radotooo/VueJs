using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TodoAppServer.Data;
using TodoAppServer.Features.Task;


namespace TodoAppServer
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<ITaskService, TaskService>();
            //services.AddCors(options =>
            //{
            //    options.AddPolicy(name: MyAllowSpecificOrigins,
            //                      builder =>
            //                      {
            //                          builder.WithOrigins("http://localhost:8080",
            //                                              "http://localhost:8081")
            //                                                .AllowAnyMethod()
            //                                                .AllowAnyOrigin()
                                                            
            //                                                .AllowAnyHeader();


            //                      }); 
            //});

            services.AddDbContext<TodoAppDbContext>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(
      options => options.WithOrigins("http://localhost:8080").AllowAnyMethod().AllowAnyHeader()
  );
            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseCors(
            //    builder => builder
            //    .WithOrigins("http://localhost:8080/?#/")
            //    .AllowAnyHeader()
            //    .AllowAnyHeader()
            //    .AllowAnyMethod()
            //    );
            //app.UseCors(MyAllowSpecificOrigins);


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
