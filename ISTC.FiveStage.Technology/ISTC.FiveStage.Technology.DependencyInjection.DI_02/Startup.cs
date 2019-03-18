using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ISTC.FiveStage.Technology.DependencyInjection.DI_02.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ISTC.FiveStage.Technology.DependencyInjection.DI_02
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<IMyService, MyService>();

            var serviceProvider = services.BuildServiceProvider();

            var instanceOne = serviceProvider.GetService<IMyService>();
            var instanceTwo = serviceProvider.GetService<IMyService>();

            Console.Write(instanceOne != instanceTwo);

        }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddSingleton<IMyService, MyService>();

        //    var serviceProvider = services.BuildServiceProvider();

        //    var instanceOne = serviceProvider.GetService<IMyService>();
        //    var instanceTwo = serviceProvider.GetService<IMyService>();

        //    Console.Write(instanceOne != instanceTwo);
        //}

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddSingleton<IMySingletonService, MySingletonService>();
        //    services.AddTransient<IMyTransientService, MyTransientService>();

        //    var serviceProvider = services.BuildServiceProvider();

        //    var singletonOne = serviceProvider.GetService<IMySingletonService>();
        //    var singletonTwo = serviceProvider.GetService<IMySingletonService>();

        //    Console.WriteLine(singletonOne == singletonTwo);
        //    Console.Write(singletonTwo.MyTransientService != singletonTwo.MyTransientService);
        //}

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddScoped<IMyScopedService, MyScopedService>();

        //    var serviceProvider = services.BuildServiceProvider();

        //    var serviceScopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();

        //    IMyScopedService scopedOne;
        //    IMyScopedService scopedTwo;

        //    using (var scope = serviceScopeFactory.CreateScope())
        //    {
        //        scopedOne = scope.ServiceProvider.GetService<IMyScopedService>();
        //    }

        //    using (var scope = serviceScopeFactory.CreateScope())
        //    {
        //        scopedTwo = scope.ServiceProvider.GetService<IMyScopedService>();
        //    }


        //    Console.Write(scopedOne != scopedTwo);
        //}
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
        }

    }
}
