using KUSY.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Entities.Concrete
{
    public class CourseStudent:EntityBase, IEntity
    {
        public decimal GradeAverage { get; set; } = 0;
        public bool IsPassed { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
