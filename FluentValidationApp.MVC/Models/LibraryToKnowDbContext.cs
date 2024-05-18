using Microsoft.EntityFrameworkCore;

namespace FluentValidationApp.MVC.Models;

public class LibraryToKnowDbContext : DbContext
{
    public LibraryToKnowDbContext(DbContextOptions<LibraryToKnowDbContext> options) : base(options)
    {
        
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Address> Addresses { get; set; }
}
