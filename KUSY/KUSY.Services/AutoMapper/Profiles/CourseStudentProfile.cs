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
    public class CourseStudentProfile:Profile
    {
        public CourseStudentProfile()
        {
            CreateMap<CourseStudentAddDto, CourseStudent>().ForMember(d=>d.CreatedDate,opt=>opt.MapFrom(x=>DateTime.Now));
            CreateMap<CourseStudentUpdateDto, CourseStudent>().ForMember(d=>d.ModifiedDate,opt=>opt.MapFrom(x=>DateTime.Now)); 
        }
    }
}
