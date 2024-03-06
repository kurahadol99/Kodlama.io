using Entities.Abstracts;

namespace Entities.Concretes;

public class Course : IEntity
{
    public int CourseId { get; set; }
    public int InstructorId { get; set; }
    public int CategoryId { get; set; }
    public int CoursePrice { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
}