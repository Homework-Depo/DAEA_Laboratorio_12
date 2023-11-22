namespace Laboratorio13;

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public int Credit { get; set; }
    public bool IsDeleted { get; set; } = false;
    
    public ICollection<Enrollment> Enrollments { get; set; }
}
