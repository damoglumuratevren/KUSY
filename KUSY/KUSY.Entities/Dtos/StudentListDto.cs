using KUSY.Entities.Concrete;
using KUSY.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Entities.Dtos
{
    public class StudentListDto : DtoGetBase
    {
        public IList<Student> Students { get; set; }

    }
}
