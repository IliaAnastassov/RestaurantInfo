using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestaurantInfo.Data;
using RestaurantInfo.Services;

namespace RestaurantInfo
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = FacebookDefaults.AuthenticationScheme;
            })
            .AddFacebook(options =>
            {
                _configuration.Bind("FacebookAuth", options);
            })
            .AddCookie();

            services.AddSingleton<IGreeter, Greeter>();
            services.AddDbContext<RestaurantInfoDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("RestaurantInfo")));
            services.AddSingleton<IRestaurantData, InMemoryRestaurantData>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILogger<Startup> logger,
            IGreeter greeter)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRewriter(new RewriteOptions().AddRedirectToHttpsPermanent());

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(rb => rb.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}"));

            app.Run(async (context) =>
            {
                var message = "Not found";
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync(message);
            });
        }
    }
}
