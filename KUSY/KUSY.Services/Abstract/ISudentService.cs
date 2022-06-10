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
    public interface ISudentService
    {
        Task<IDataResult<StudentDto>> Get(string studentCode);

        Task<IDataResult<StudentListDto>> GetAll();

        Task<IDataResult<StudentListDto>> GetAllByNonDeleted();

        Task<IDataResult<StudentListDto>> GetAllByNonDeletedAndNonGraduate();

        Task<IDataResult<StudentListDto>> GetAllByNonDeletedAndNonGraduateCourse(int courseId);

        Task<IResult> Add(StudentAddDto studentAddDto, int createdById);

        Task<IResult> Update(StudentUpdateDto studentUpdateDto, int modifiedById);

        Task<IResult> Delete(string studentCode ,int modifiedById);

        Task<IResult> HardDelete(string studentCode, int modifiedById);
    }
}
