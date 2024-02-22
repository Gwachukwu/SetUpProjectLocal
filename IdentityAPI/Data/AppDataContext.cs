using Microsoft.EntityFrameworkCore;
using IdentityAPI.Models;

namespace IdentityAPI.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options)
    : base(options)
    { }

    public DbSet<TestModel> Testmodels { get; set; }
}