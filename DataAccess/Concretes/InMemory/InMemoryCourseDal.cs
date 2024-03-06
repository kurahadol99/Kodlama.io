using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes.InMemory;

public class InMemoryCourseDal : ICourseDal
{
    private List<Course> _courses;

    public InMemoryCourseDal()
    {
        _courses = new List<Course>
        {
            new Course
            {
                CourseId = 1, CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
                CategoryId = 1, CourseDescription = "C##", CoursePrice = 0, InstructorId = 1
            },
            new Course
            {
                CourseId = 2, CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                CategoryId = 1, CourseDescription = "C#", CoursePrice = 0, InstructorId = 1
            },
            new Course
            {
                CourseId = 3, CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)",
                CategoryId = 2, CourseDescription = "Python and Selenium", CoursePrice = 0, InstructorId = 2
            },
            new Course
            {
                CourseId = 4, CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)",
                CategoryId = 3, CourseDescription = "Java", CoursePrice = 0, InstructorId = 1
            },
            new Course
            {
                CourseId = 5, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                CategoryId = 4, CourseDescription = "Javascript", CoursePrice = 0, InstructorId = 1
            },
            new Course
            {
                CourseId = 6, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA & REACT)",
                CategoryId = 5, CourseDescription = "Java and React", CoursePrice = 0, InstructorId = 1
            },
            new Course
            {
                CourseId = 7, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
                CategoryId = 6, CourseDescription = "C# and Angular", CoursePrice = 0, InstructorId = 1
            },
            new Course
            {
                CourseId = 8, CourseName = "Programlamaya Giriş için Temel Kurs",
                CategoryId = 7, CourseDescription = "Programming 101", CoursePrice = 0, InstructorId = 1
            }

        };
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public List<Course> GetAllByCategoryId(int categoryId)
    {
       return _courses.Where(p => p.CategoryId == categoryId).ToList();
    }

    public Course Get(int courseId)
    {
        var coursToGet = _courses.SingleOrDefault(p => p.CourseId == courseId);
        return coursToGet;
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Update(Course course)
    {
        var courseToUpdate = _courses.SingleOrDefault(p => p.CourseId == course.CourseId);
        courseToUpdate.CourseName = course.CourseName;
        courseToUpdate.CourseDescription = course.CourseDescription;
        courseToUpdate.CoursePrice = course.CoursePrice;
        courseToUpdate.CategoryId = course.CategoryId;
        courseToUpdate.InstructorId = course.InstructorId;
    }

    public void Delete(Course course)
    {
        Course courseToDelete = null;
        // foreach (var c in _courses)
        // {
        //     if (course.CourseId == c.CourseId)
        //     {
        //         courseToDelete = c;
        //     }
        // }
        // _courses.Remove(courseToDelete);

        courseToDelete = _courses.SingleOrDefault(p => p.CourseId == course.CourseId);
        _courses.Remove(courseToDelete);
    }
}