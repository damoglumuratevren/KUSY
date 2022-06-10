using KUSY.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Entities.Dtos
{
    public class CourseStudentUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Öğrenci ders notu")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(0, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(4, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public decimal GradeAverage { get; set; }

        [DisplayName("Öğrenci ders gecti mi?")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        public bool IsPassed { get; set; }

        [DisplayName("Öğrenci ders notu")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int StudentId { get; set; }
        public KUSY.Entities.Concrete.Student Student { get; set; }


        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }
    }
}
