using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ISTC.FiveStage.Technology.Middleware_01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                Console.WriteLine("A (before)");
                await next();
                Console.WriteLine("A (after)");
            });

            app.UseWhen(
                context => context.Request.Path.StartsWithSegments(new PathString("/foo")),
                a => a.Use(async (context, next) =>
                {
                    Console.WriteLine("B (before)");
                    await next();
                    Console.WriteLine("B (after)");
                }));

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Get}/{id?}");
            });

            //app.Run(async context =>
            //{
            //    Console.WriteLine("C");
            //    await context.Response.WriteAsync("Hello world");
            //    await context.Response.WriteAsync("Hello world2");
            //});
        }
    }
}
