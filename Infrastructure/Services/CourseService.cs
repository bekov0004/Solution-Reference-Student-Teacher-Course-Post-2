namespace Infrastructure.Services;
using Domain.Models;
public class CourseService
{
    private List<Course> courses;
    public CourseService()
    {
        courses = new List<Course>();
    }
    public List<Course> GetCourses()
    {
        return courses;
    }
    public void AddCourses(Course course)
    {
        courses.Add(course);
    }
    public void UpdateStudent(Course course)
    {
        var existing = courses.Find(e => e.Id == course.Id);
        if (existing == null) return;  
        existing.Fee = course.Fee;
        existing.Description = course.Description;
    }

    public void Delete(int id)
    {
        var existing = courses.Find(e => e.Id == id);
        if (existing == null) return;
        courses.Remove(existing);
    }
}
