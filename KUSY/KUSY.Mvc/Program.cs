using AutoMapper;
using KUSY.Services.AutoMapper.Profiles;
using KUSY.Services.Extensions;

namespace KUSY.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

             static void ConfigureServices(IServiceCollection services)
            {
                services.LoadMyServices();
                services.AddControllersWithViews().AddRazorRuntimeCompilation();
                var mapperConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new CourseStudentProfile());
                    mc.AddProfile(new StudentProfile());
                });

                IMapper mapper = mapperConfig.CreateMapper();
                services.AddSingleton(mapper);
            }

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePages();
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();




            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}