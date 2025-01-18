using Microsoft.EntityFrameworkCore;

namespace DigitalPaws.Models
{
	public class DigitalPawsContext : DbContext
	{
		public DigitalPawsContext(DbContextOptions<DigitalPawsContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Pet> Pets { get; set; }
	}
}
