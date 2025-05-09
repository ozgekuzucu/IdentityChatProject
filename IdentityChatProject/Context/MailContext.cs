using IdentityChatProject.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatProject.Context
{
	public class MailContext : IdentityDbContext<AppUser>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-PUNASPD;initial Catalog=IdentityChatDb;integrated Security=true;trust server certificate=true");
		}
		public DbSet<Message> Messages { get; set; }
	}
}
