// See https://aka.ms/new-console-template for more information

using Business.Concretes;
using DataAccess.Concretes.InMemory;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
foreach (var c in courseManager.GetAll())
{
    Console.WriteLine(c.CourseName);
}
Console.ReadLine();