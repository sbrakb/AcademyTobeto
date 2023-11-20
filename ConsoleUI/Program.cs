
using Business.Concretes;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

//CourseTest();

//InstructorTest();

//CategoryTest();

DetailsTest();

static void CourseTest()
{
    CourseManager courseManager = new CourseManager(new EfCourseDal());

    Course course = new Course()
    {
        Name = "flutter",
        CategoryId = 1,
        InstructorId = 1,
        Price = 7500000
    };

    Console.WriteLine(courseManager.Add(course).Message);


    //Console.WriteLine(courseManager.DeleteAll().Message);

    var courseList = courseManager.GetAll();

    foreach (var c in courseList.Data)
    {
        Console.WriteLine(c.Id + " " + c.Name + " " + c.CategoryId + " " + c.InstructorId + " " + c.Price);
    }
}

static void InstructorTest()
{
    InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

    Instructor instructor = new()
    {
        FirstName = "Halit Enes",
        LastName = "Kalaycı"
    };

    var addedResult = instructorManager.Add(instructor);
    Console.WriteLine(addedResult.Message + " " + addedResult.Succes);

    Console.WriteLine(instructorManager.Add(instructor).Message);

    var deletedResult = instructorManager.DeleteById(4);
    Console.WriteLine(deletedResult.Message + " " + deletedResult.Succes);


    Console.WriteLine(instructorManager.DeleteAll().Message + " " + instructorManager.DeleteAll().Succes);


    var instructors = instructorManager.GetAll();
    Console.WriteLine(instructors.Data.Count);

    foreach (var i in instructors.Data)
    {
        Console.WriteLine(i.FirstName + " " + i.LastName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    Category category = new() { Name = "Siber" };
    categoryManager.Add(category);

    Console.WriteLine(categoryManager.DeleteAll().Message);

    foreach (var c in categoryManager.GetAll().Data)
    {
        Console.WriteLine(c.Id + " " + c.Name);
    }
}

static void DetailsTest()
{
    CourseManager courseManager = new CourseManager(new EfCourseDal());

    foreach (var c in courseManager.GetCourseDetails().Data)
    {
        Console.WriteLine(c.CourseId + " " + c.CourseName + " " + c.CategoryName + " " + c.InstructorName);
    }
}