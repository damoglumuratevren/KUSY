using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Entities.Dtos
{
    public class StudentAddDto
    {
        [DisplayName("Öğrenci Adı")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Öğrenci Soyadı")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Öğrenci Codu")]
        [MaxLength(12, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(12, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string StudentCode { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Ögrenci Email adresi")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(15, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Ögrenci telefon numarasi")]
        [MaxLength(10, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Ögrenci resmi")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string Thumbnail { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Ögrenci kayıt zamanı")]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime RegistrationTime { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Ögrenci mezun oldu mu?")]
        public bool IsGraduate { get; set; }
    }
}
