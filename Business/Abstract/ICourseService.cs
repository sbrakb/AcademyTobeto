
using Core.Utilities.Result;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService:IGenericService<Course>
    {

        IDataResult<List<CourseDetailDto>> GetCourseDetails();

    }
}
