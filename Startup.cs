using System.Text;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace Kurs
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/users", async context =>
                {
                    //throw new Exception("pfodspf");
                    int userId = 0;
                    if (!Int32.TryParse(context.Request.Query["Id"], out userId))
                    {
                        userId = -1;
                    }

                    var usersRepository = new UsersRepository();
                    User User = usersRepository.getUserById(userId);
                    await context.Response.WriteAsync(JsonConvert.SerializeObject(User), Encoding.UTF8);
                });
            });
        }
    }
}
