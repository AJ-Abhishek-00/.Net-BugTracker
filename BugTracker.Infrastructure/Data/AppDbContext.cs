using Microsoft.EntityFrameworkCore;
using BugTracker.Domain.Entities;


namespace BugTracker.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Defect> Defects => Set<Defect>();
    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();
}