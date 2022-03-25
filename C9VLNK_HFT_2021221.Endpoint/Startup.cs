using C9VLNK_HFT_2021221.Data;
using C9VLNK_HFT_2021221.Endpoint.Services;
using C9VLNK_HFT_2021221.Logic;
using C9VLNK_HFT_2021221.Repository.Interfaces;
using C9VLNK_HFT_2021221.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace C9VLNK_HFT_2021221.Endpoint
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IArtistLogic, ArtistLogic>();
            services.AddTransient<IAlbumLogic, AlbumLogic>();
            services.AddTransient<ISongLogic, SongLogic>();
            services.AddTransient<IArtistRepository, ArtistRepository>();
            services.AddTransient<IAlbumRepository, AlbumRepository>();
            services.AddTransient<ISongRepository, SongRepository>();
            services.AddSingleton<MusicContext, MusicContext>();
            services.AddSignalR();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MovieDbApp.Endpoint", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieDbApp.Endpoint v1"));
            }

            app.UseExceptionHandler(c => c.Run(async context =>
            {
                var exception = context.Features
                    .Get<IExceptionHandlerPathFeature>()
                    .Error;
                var response = new { Msg = exception.Message };
                await context.Response.WriteAsJsonAsync(response);
            }));

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<SignalRHub>("/hub");
            });
        }
    }
}
