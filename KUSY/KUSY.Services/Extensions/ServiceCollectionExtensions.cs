using KUSY.Data.Abstract;
using KUSY.Data.Concrete;
using KUSY.Data.Concrete.EntityFremework.Contexts;
using KUSY.Services.Abstract;
using KUSY.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceColleciton)
        {
            serviceColleciton.AddDbContext<KusyContext>();
            serviceColleciton.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceColleciton.AddScoped<ISudentService, StudentManager>();
            serviceColleciton.AddScoped<ICourseStudentService, CourseStudentManager>();
            return serviceColleciton;
        }
    }
}
