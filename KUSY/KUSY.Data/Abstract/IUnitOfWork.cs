using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {

        ICourseRepository Courses { get; }

        ICourseStudentRepository CourseStudents { get; }

        IStudentRepository Students { get; }

        IRoleRepository Roles { get; }

        IUserRepository Users { get; }

        Task<int> SaveAsync();
    }
}
