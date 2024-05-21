using LearningBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningBlazor.Data;

public class AppDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
    }

    public DbSet<Counters> Counters { get; set; }
}