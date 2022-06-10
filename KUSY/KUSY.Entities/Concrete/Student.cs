using KUSY.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Entities.Concrete
{
    public class Student : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Thumbnail { get; set; }
        public DateTime RegistrationTime { get; set; }
        public DateTime? GraduationTime { get; set; }
        public bool IsGraduate { get; set; }
       // public  CourseStudent CourseStudent { get; set; }
        public ICollection<CourseStudent> CourseStudents { get; set; }

    }
}
