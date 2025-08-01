using System.Runtime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ProjectLogin.Models;

public class LoginDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Profile => Set<User>();
    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<User>();
    }
}