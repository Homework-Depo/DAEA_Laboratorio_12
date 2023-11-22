namespace Laboratorio13;

public class Student
{
    public int StudentId { get; set; }
    public int Grade_idGrade { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    
    public Grade Grade { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
}
