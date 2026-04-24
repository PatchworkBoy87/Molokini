using Microsoft.EntityFrameworkCore;
using Molokini.Core.Entities;
using Molokini.Shared.Contracts.DTOs;
using Molokini.Shared.Models;

namespace Molokini.Infrastructure.Data;

public class MolokiniDbContext : DbContext
{
    public MolokiniDbContext(DbContextOptions<MolokiniDbContext> options) : base(options) { }

    public DbSet<WasteEntry> WasteEntries => Set<WasteEntry>();
    public DbSet<WasteJob> WasteJobEntries => Set<WasteJob>();
    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<WasteEntry>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<WasteJob>(entity =>
        {
            entity.HasKey(e => e.Id);
        });
    }
}