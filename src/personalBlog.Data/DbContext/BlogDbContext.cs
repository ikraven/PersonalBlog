using Microsoft.EntityFrameworkCore;
using personalBlog.DAta.DbContext.Mappings;
using personalBlog.Domain.Models.Posts;

namespace personalBlog.DAta.DbContext;

public class BlogDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    /// <summary>
    /// Posts del blog
    /// </summary>
    public DbSet<Post> Posts { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=blog.db");
        base.OnConfiguring(optionsBuilder);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Mapeos
        modelBuilder.ApplyConfiguration(new PostMapping());

    }
}