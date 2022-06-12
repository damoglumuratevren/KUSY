using AutoMapper;
using KUSY.Data.Abstract;
using KUSY.Entities.Concrete;
using KUSY.Entities.Dtos;
using KUSY.Services.Abstract;
using KUSY.Shared.Utilities.Results.Abstract;
using KUSY.Shared.Utilities.Results.ComplexType;
using KUSY.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Services.Concrete
{
    public class CourseStudentManager : ICourseStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CourseStudentManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper=mapper;
        }

        public async Task<IResult> Add(CourseStudentAddDto courseStudentAddDto, int createdById)
        {
            var courseStudent = _mapper.Map<CourseStudent>(courseStudentAddDto);
            courseStudent.CreatedById = createdById;
            courseStudent.ModifiedById = createdById;
            await _unitOfWork.CourseStudents.AddAsync(courseStudent);
            await _unitOfWork.SaveAsync();

            return new Result(ResultStatus.Success, "Basarılı şekilde eklenmiştir.");
        }

        public async Task<IResult> Delete(int courseStudentId, int modifiedById)
        {
            var rst = await _unitOfWork.CourseStudents.AnyAsync(a=>a.Id==courseStudentId);
            if (rst)
            {
                var cs = await _unitOfWork.CourseStudents.GetAsync(a => a.Id == courseStudentId);
                cs.ModifiedById = modifiedById;
                cs.IsDeleted = true;
                cs.ModifiedDate = DateTime.Now;
                await _unitOfWork.CourseStudents.UpdateAsync(cs);
                await _unitOfWork.SaveAsync();

                return new Result(ResultStatus.Success, "Basarılı şekilde Silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Kayıt bulunmamıştır.");

        }

        public async Task<IDataResult<CourseStudentDto>> Get(int courseStudentId)
        {
            var courseStudent = await _unitOfWork.CourseStudents.GetAsync(a=>a.Id==courseStudentId,x=>x.Course,q=>q.Student);
            if (courseStudent != null)
            {
                return new DataResult<CourseStudentDto>(ResultStatus.Success,new CourseStudentDto
                {
                    CourseStudent=courseStudent,
                    ResultStatus=ResultStatus.Success
                });
            }
            return new DataResult<CourseStudentDto>(ResultStatus.Error, "Kayıt bulunamadı", null);
        }

        public async Task<IDataResult<CourseStudentListDto>> GetAll()
        {
            var courseStudents = await _unitOfWork.CourseStudents.GetAllAsync(null, x => x.Course, q => q.Student);
            if (courseStudents.Count > -1)
            {
                return new DataResult<CourseStudentListDto>(ResultStatus.Success, new CourseStudentListDto
                {
                    CourseStudents = courseStudents,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CourseStudentListDto>(ResultStatus.Error, "Kayıt bulunamadı", null);
        }

        public async Task<IDataResult<CourseStudentListDto>> GetAllByNonDeleted()
        {
            var courseStudents = await _unitOfWork.CourseStudents.GetAllAsync(a=>!a.IsDeleted, x => x.Course, q => q.Student);
            if (courseStudents.Count > -1)
            {
                return new DataResult<CourseStudentListDto>(ResultStatus.Success, new CourseStudentListDto
                {
                    CourseStudents = courseStudents,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CourseStudentListDto>(ResultStatus.Error, "Kayıt bulunamadı", null);

        }

        public async Task<IDataResult<CourseStudentListDto>> GetAllByNonDeletedAndNonPassed()
        {
            var courseStudents = await _unitOfWork.CourseStudents.GetAllAsync(cp => !cp.IsDeleted && !cp.IsPassed, x => x.Course, q => q.Student);
            if (courseStudents.Count > -1)
            {
                return new DataResult<CourseStudentListDto>(ResultStatus.Success, new CourseStudentListDto
                {
                    CourseStudents = courseStudents,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CourseStudentListDto>(ResultStatus.Error, "Kayıt bulunamadı", null);
        }

        public async Task<IDataResult<CourseStudentListDto>> GetAllByNonDeletedAndPassed()
        {
            var courseStudents = await _unitOfWork.CourseStudents.GetAllAsync(cp => !cp.IsDeleted && cp.IsPassed, x => x.Course, q => q.Student);
            if (courseStudents.Count > -1)
            {
                return new DataResult<CourseStudentListDto>(ResultStatus.Success, new CourseStudentListDto
                {
                    CourseStudents = courseStudents,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CourseStudentListDto>(ResultStatus.Error, "Kayıt bulunamadı", null);
        }

        public async Task<IDataResult<CourseStudentListDto>> GetAllByNonDeletedAndPassedStudent()
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(CourseStudentUpdateDto courseStudentUpdateDto, int modifiedById)
        {
            var cs=_mapper.Map<CourseStudent>(courseStudentUpdateDto); 
            cs.ModifiedById = modifiedById;
            await _unitOfWork.CourseStudents.UpdateAsync(cs);
            await _unitOfWork.SaveAsync();

            return new Result(ResultStatus.Success, "Basarılı şekilde güncellenmiştir.");
        }
    }
}
