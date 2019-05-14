using Microsoft.EntityFrameworkCore;

namespace Train10.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=blogging.db");
        }

        public DbSet<Models.Blog> Blogs { get; set; }
        public DbSet<Models.Post> Posts { get; set; }
        public DbSet<Models.Comment> Comments { get; set; }

        public DbSet<Models.Name> Names { get;set;}

    }

    public class Name {
        public int id { get; set; }
        public string Text { get; set; }    
        
    }
}