using Microsoft.EntityFrameworkCore;

namespace FluentValidationApp.API.Models;

public class FluentValidationApiContext : DbContext
{
	public FluentValidationApiContext(DbContextOptions<FluentValidationApiContext> options) : base(options)
	{
	}

	public DbSet<Customer> Customers { get; set; }
}
