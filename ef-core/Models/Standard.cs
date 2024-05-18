using System.ComponentModel.DataAnnotations.Schema;

namespace ef_core.Models;

public class Standard
{
    public int StandardId { get; set; }
    public string StandardName { get; set; }
    
    [ForeignKey("StandardRefId")]
    public ICollection<Student> Students { get; set; }
}