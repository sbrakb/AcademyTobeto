using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public IResult Add(Course course)
        {
            if (course.Name=="x")
            {
                return new ErrorResult(Messages.CourseNameInvalid);
            }
            _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CourseDeleted);
        }

        public IResult DeleteAll()
        {
            foreach (var course in _courseDal.GetAll())
            {
                _courseDal.Delete(course);
            }
            return new SuccessResult(Messages.DeletedCourseList);
        }

        public IResult DeleteById(int id)
        {
            _courseDal.Delete(_courseDal.Get(c => c.Id == id));
            return new SuccessResult(Messages.DeletedById);
        }

        public IDataResult<Course> Get(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(c=>c.Id == id),Messages.FoundById);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CourseList);
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetail(),Messages.Details);
        }

        public IResult Update(Course Course)
        {
            _courseDal.Update(Course);
            return new SuccessResult(Messages.Updated);
        }
    }
}
