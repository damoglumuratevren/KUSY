using AutoMapper;
using KUSY.Services.AutoMapper.Profiles;
using KUSY.Services.Extensions;

namespace KUSY.MVCV2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            static void ConfigureServices(IServiceCollection services)
            {
                services.LoadMyServices();
                services.AddAutoMapper(typeof(CourseStudentProfile),typeof(StudentProfile));
                services.AddControllersWithViews().AddRazorRuntimeCompilation();
                //var mapperConfig = new MapperConfiguration(mc =>
                //{
                //    mc.AddProfile(new CourseStudentProfile());
                //    mc.AddProfile(new StudentProfile());
                //});

                //IMapper mapper = mapperConfig.CreateMapper();
                //services.AddSingleton(mapper);
            }

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseStatusCodePages();
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}