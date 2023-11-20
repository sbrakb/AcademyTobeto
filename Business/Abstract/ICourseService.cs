
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
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<Course> Get(int id);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(Course course);
        IResult DeleteById(int id);
        IResult DeleteAll();
    }
}
