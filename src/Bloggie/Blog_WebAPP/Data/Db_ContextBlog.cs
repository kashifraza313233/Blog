using Blog_WebAPP.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog_WebAPP.Data
{
    public class Db_ContextBlog : DbContext
    {
        public Db_ContextBlog(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<BlogPost> BlobPots { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
