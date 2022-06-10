using KUSY.Data.Abstract;
using KUSY.Entities.Concrete;
using KUSY.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Data.Concrete.EntityFremework.Repositories
{
    public class EfStudentRepository : EfEntityRepositoryBase<Student>, IStudentRepository
    {
        public EfStudentRepository(DbContext context) : base(context)
        {
        }
    }
}
