namespace ef_core.Models;


// self employ
public class Employee
{
	public int Id { get; set; }

	public int? ManagerId { get; set; } // Optional foreign key property
	public Employee? Manager { get; set; } // Optional reference navigation to principal
	public ICollection<Employee> Reports { get; set; } = new List<Employee>(); // Collection navigation containing dependents
}
