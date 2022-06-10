using KUSY.Entities.Concrete;
using KUSY.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Entities.Dtos
{
    public class CourseStudentDto : DtoGetBase
    {
        public CourseStudent CourseStudent { get; set; }

    }
}
