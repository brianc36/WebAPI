using HelloAPI.Services;
using HelloData;
using HelloAPI.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HelloAPI
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
            var useEF = Configuration.GetValue<bool>("UseEF");


            //Could be swapped out in config to use other service.
           var serviceTypeName = "HelloAPI.Services.ValueService";
           Type serviceInterface = Type.GetType("HelloAPI.Interfaces.IService");
           Type serviceType = Type.GetType(serviceTypeName);

            services.AddDbContext<HelloContext>(options =>
                                               options.UseSqlServer(Configuration.GetConnectionString("HelloConnection")));

            services.AddTransient(serviceInterface, serviceType);
            //services.AddTransient<IService, ContextService>();
            //services.AddTransient<IService, ValueService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
