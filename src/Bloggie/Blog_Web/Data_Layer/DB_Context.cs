using Blog_Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog_Web.Data_Layer
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions options):base(options)
        {

        }
        public DbSet<BlogPosts> Blob_Posts { get; set; }
        public DbSet<Tags> Blog_Tags { get; set; }
    }
}
