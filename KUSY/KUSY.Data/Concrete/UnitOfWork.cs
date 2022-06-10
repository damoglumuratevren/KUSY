using KUSY.Data.Abstract;
using KUSY.Data.Concrete.EntityFremework.Contexts;
using KUSY.Data.Concrete.EntityFremework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KusyContext _context;
        private EfRoleRepository _roleRepository;
        private EfUserRepository _userRepository;
        private EfCourseRepository _courseRepository;
        private EfCourseStudentRepository _courseStudentRepository; 
        private EfStudentRepository _studentRepository;


        public UnitOfWork(KusyContext context)
        {
            _context = context; 
        }
        public ICourseRepository Courses => _courseRepository ?? new EfCourseRepository(_context);

        public ICourseStudentRepository CourseStudents => _courseStudentRepository?? new EfCourseStudentRepository(_context);   

        public IStudentRepository Students => _studentRepository ?? new EfStudentRepository(_context);  

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
