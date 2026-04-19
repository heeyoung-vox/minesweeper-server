using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace minesweeper_server.Models;

public class MatchEntity
{
    public Guid Id { get; set; }

    [Required]
    public string UserId { get; set; } = string.Empty;

    public int Width { get; set; }

    public int Height { get; set; }

    public int MineCount { get; set; }

    public bool MinesPlaced { get; set; }

    public string? MinePositions { get; set; } // JSON string of mine positions

    public string? RevealedCells { get; set; } // JSON string of revealed cells

    public double ElapsedSeconds { get; set; }

    public MatchStatus Status { get; set; }

    public DateTime? StartedAt { get; set; }

    public DateTime? PausedAt { get; set; }

    public DateTime? CompletedAt { get; set; }

    // Navigation property back to IdentityUser
    public virtual IdentityUser User { get; set; } = null!;
}

public enum MatchStatus
{
    Active,
    Paused,
    Won,
    Lost
}
