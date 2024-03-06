using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();
    List<Course> GetAllByCategoryId(int categoryId);
    Course Get(int courseId);
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
}