
using KUSY.Entities.Concrete;
using KUSY.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Entities.Dtos
{
    public class CourseStudentListDto:DtoGetBase
    {
        public IList<CourseStudent> CourseStudents { get; set; }
    }
}
