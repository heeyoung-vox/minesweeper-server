using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using minesweeper_server.Models;

namespace minesweeper_server.Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<MatchEntity> Matches { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Configure MatchEntity
        builder.Entity<MatchEntity>(entity =>
        {
            entity.HasKey(e => e.Id);
            
            // Configure jsonb columns for PostgreSQL
            entity.Property(e => e.MinePositions)
                .HasColumnType("jsonb");
            
            entity.Property(e => e.RevealedCells)
                .HasColumnType("jsonb");
            
            // Configure indexes for efficient statistics queries
            entity.HasIndex(e => e.UserId);
            entity.HasIndex(e => e.Status);
            entity.HasIndex(e => e.CompletedAt);
            
            // Configure relationship with IdentityUser
            entity.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
