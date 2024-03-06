using Entities.Concretes;

namespace Business.Abstracts;

public interface ICourseService
{
    List<Course> GetAll();
    
}