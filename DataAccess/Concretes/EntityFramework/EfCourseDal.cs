using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, AcademyContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetail()
        {
            using (AcademyContext ctx = new())
            {
                var result = from co in ctx.Courses
                             join i in ctx.Instructors
                             on co.InstructorId equals i.Id
                             join ca in ctx.Categories
                             on co.CategoryId equals ca.Id
                             select new CourseDetailDto
                             {
                                 CourseId = co.Id,
                                 CourseName = co.Name,
                                 InstructorName = i.FirstName + " " + i.LastName,
                                 CategoryName = ca.Name
                             };
                return result.ToList();                           
            }
        }
    }
}
