using Microsoft.EntityFrameworkCore;

namespace Blog.Models.PostContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : 
            base(options)
        { }
        public DbSet<Post> Posts { get; set; }
    }
}
