using ef_core.Models;
using Microsoft.EntityFrameworkCore; // Add this line

namespace ef_core.Data;

public partial class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

	public virtual DbSet<Student> Students { get; set; }
	public virtual DbSet<Standard> Standards { get; set; }
	public virtual DbSet<Employee> Employees { get; set; }
}
