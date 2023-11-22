namespace Laboratorio13;

public class Enrollment
{
    public int EnrollmentId { get; set; }
    public int Student_idStudent { get; set; }
    public int Course_idCourse { get; set; }
    public DateTime Date { get; set; }
    public Course Course { get; set; }
    public Student Student { get; set; }
}
