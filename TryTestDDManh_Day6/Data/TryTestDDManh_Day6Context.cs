using Microsoft.EntityFrameworkCore;

public class TryTestDDManh_Day6Context(DbContextOptions<TryTestDDManh_Day6Context> options) : DbContext(options)
{
    public DbSet<TryTestDDManh_Day6.Models.Genre> Genre { get; set; } = default!;

    public DbSet<TryTestDDManh_Day6.Models.Movie> Movie { get; set; } = default!;
}
