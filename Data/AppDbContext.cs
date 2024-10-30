using Microsoft.EntityFrameworkCore;
using Reg.Models;

namespace Reg.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> db)
			: base(db)
		{
		}
		public DbSet<User> Users { get; set; }	
	}
}
