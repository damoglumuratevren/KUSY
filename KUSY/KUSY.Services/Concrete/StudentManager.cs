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
    public class StudentManager : ISudentService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StudentManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> Add(StudentAddDto studentAddDto, int createdById)
        {
            var student=_mapper.Map<Student>(studentAddDto);
            student.ModifiedById = createdById;
            student.CreatedById = createdById;
            await _unitOfWork.Students.AddAsync(student).ContinueWith(t=>_unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{studentAddDto.FirstName + " " + studentAddDto.LastName} öğrencisi eklenmiştir.");
        }

        public async Task<IResult> Delete(string studentCode, int modifiedById)
        {
            var student = await _unitOfWork.Students.GetAsync(x => x.StudentCode == studentCode);
            if (student != null)
            {
                student.IsDeleted = true;
                student.ModifiedById = modifiedById;
                student.ModifiedDate = DateTime.Now;
                await _unitOfWork.Students.UpdateAsync(student).ContinueWith(d=>_unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success,$"{student.FirstName +" " + student.LastName} Adlı ögrenci silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Ögrenci bulunamadı");
        }

        public async Task<IDataResult<StudentDto>> Get(string studentCode)
        {
            var student = await _unitOfWork.Students.GetAsync(s=>s.StudentCode==studentCode, s1=>s1.CourseStudents);
            if (student != null)
            {
                return new DataResult<StudentDto>(ResultStatus.Success, new StudentDto
                {
                    Student=student,
                    ResultStatus=ResultStatus.Success
                });
            }
            return new DataResult<StudentDto>(ResultStatus.Error, "Öğrenci bulunamadı", null);
        }

        public async Task<IDataResult<StudentListDto>> GetAll()
        {
            var students = await _unitOfWork.Students.GetAllAsync(null,c=>c.CourseStudents);
            if (students.Count > -1)
            {
                return new DataResult<StudentListDto>(ResultStatus.Success, new StudentListDto
                {
                    Students = students,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<StudentListDto>(ResultStatus.Error, "Öğrenci bulunamadı", null);

        }

        public async Task<IDataResult<StudentListDto>> GetAllByNonDeleted()
        {

            var students = await _unitOfWork.Students.GetAllAsync(z=>!z.IsDeleted, c=>c.CourseStudents);
            if (students.Count > -1)
            {
                return new DataResult<StudentListDto>(ResultStatus.Success, new StudentListDto
                {
                    Students=students,
                    ResultStatus= ResultStatus.Success  
                });
            }
            return new DataResult<StudentListDto>(ResultStatus.Error,"Kayıt bulunamadı.",null);
        }

        public async Task<IDataResult<StudentListDto>> GetAllByNonDeletedAndNonGraduate()
        {
            var students = await _unitOfWork.Students.GetAllAsync(z => !z.IsDeleted&&!z.IsGraduate, c => c.CourseStudents);
            if (students.Count > -1)
            {
                return new DataResult<StudentListDto>(ResultStatus.Success, new StudentListDto
                {
                    Students = students,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<StudentListDto>(ResultStatus.Error, "Kayıt bulunamadı.", null);
        }

        public async Task<IDataResult<StudentListDto>> GetAllByNonDeletedAndNonGraduateCourse(int courseId)
        {
            var students = await _unitOfWork.Students.GetAllAsync(z => !z.IsDeleted && !z.IsGraduate, c => c.CourseStudents);
            if (students.Count > -1)
            {
                return new DataResult<StudentListDto>(ResultStatus.Success, new StudentListDto
                {
                    Students = students,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<StudentListDto>(ResultStatus.Error, "Kayıt bulunamadı.", null);
        }

        public async Task<IResult> HardDelete(string studentCode, int modifiedById)
        {
            var student = await _unitOfWork.Students.GetAsync(x=>x.StudentCode==studentCode);
            if (student != null)
            {
                await _unitOfWork.Students.DeleteAsync(student).ContinueWith(q => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{student.FirstName + " " + student.LastName} adlı ögrenci silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Ögrenci bulunamadı");
        }

        public async Task<IResult> Update(StudentUpdateDto studentUpdateDto, int modifiedById)
        {
            var student = _mapper.Map<Student>(studentUpdateDto);
            student.ModifiedById = modifiedById;
            student.ModifiedDate = DateTime.Now;
            await _unitOfWork.Students.UpdateAsync(student).ContinueWith(f=>_unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{studentUpdateDto.StudentCode} numaralı ögrenci guncellenmiştir.");                
        }
    }
}
