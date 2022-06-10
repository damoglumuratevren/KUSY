using KUSY.Entities.Concrete;
using KUSY.Entities.Dtos;
using KUSY.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Services.Abstract
{
    public interface ICourseStudentService
    {
        Task<IDataResult<CourseStudentDto>> Get(int courseStudentId);

        Task<IDataResult<CourseStudentListDto>> GetAll();

        Task<IDataResult<CourseStudentListDto>> GetAllByNonDeleted();

        Task<IDataResult<CourseStudentListDto>> GetAllByNonDeletedAndNonPassed();

        Task<IDataResult<CourseStudentListDto>> GetAllByNonDeletedAndPassed();

        Task<IDataResult<CourseStudentListDto>> GetAllByNonDeletedAndPassedStudent();

        Task<IResult> Add(CourseStudentAddDto courseStudentAddDto, int createdById);

        Task<IResult> Update(CourseStudentUpdateDto courseStudentUpdateDto, int modifiedById);

        Task<IResult> Delete(int courseStudentId, int modifiedById);

    }
}
