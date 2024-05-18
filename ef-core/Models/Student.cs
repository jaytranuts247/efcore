namespace ef_core.Models;

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
        
    public int? StandardRefId { get; set; }
    public Standard Standard { get; set; }
}