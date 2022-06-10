using KUSY.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Entities.Concrete
{
    public class Course: EntityBase,IEntity
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CoursePeriyod { get; set; }//1. dönem 2. dönem 3.dönem vs
        public string FacultyCode { get; set; }//???

        //public int StudentId { get; set; }
        //public Student Student { get; set; }


        public int UserID { get; set; }

        public User User  { get; set; }

        //public int CourseStudentId { get; set; }
        //public CourseStudent CourseStudent { get; set; }

        public ICollection<CourseStudent> CourseStudents { get; set; }
    }
}
