namespace Laboratorio13;

public class Grade
{
    public int GradeId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsDeleted { get; set; } = false;
    
    public ICollection<Student> Students { get; set; }
}
