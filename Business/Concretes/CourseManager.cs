using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    private ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public List<Course> GetAll()
    {
        // Business codes...
        return _courseDal.GetAll();
    }
}