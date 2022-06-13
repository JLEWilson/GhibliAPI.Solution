using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace GhibliAPI.Models
{
  public class GhibliAPIContext : DbContext
  {
    public GhibliAPIContext(DbContextOptions<GhibliAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Work> Works { get; set; } = null!;
  }
}