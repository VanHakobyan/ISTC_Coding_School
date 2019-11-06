using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISTC.FiveStage.Technology.DependencyInjection.DI_01.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ISTC.FiveStage.Technology.DependencyInjection.DI_01
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddScoped<IFirstService, FirstService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var name = env.ApplicationName;

            app.UseHttpsRedirection();
            app.UseRouting();           
            app.UseEndpoints((x) => x.MapControllers());
            
        }
    }
}
