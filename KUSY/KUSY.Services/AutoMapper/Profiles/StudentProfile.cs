using AutoMapper;
using KUSY.Entities.Concrete;
using KUSY.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Services.AutoMapper.Profiles
{
    public class StudentProfile:Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentAddDto, Student>().ForMember(d => d.CreatedDate, o => o.MapFrom(q => DateTime.Now));
            CreateMap<StudentUpdateDto, Student>().ForMember(d => d.ModifiedDate, o => o.MapFrom(q => DateTime.Now));
        }
    }
}
