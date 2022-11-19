namespace ApiProyecto1002.Context;
    using ApiProyecto1002.Models;
    using Microsoft.EntityFrameworkCore;
{
    public class AppDbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
    {

    }
    public DbSet<usuarios> usuarios { get; set; }
    }
}
