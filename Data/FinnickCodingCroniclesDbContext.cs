using Microsoft.EntityFrameworkCore;
using TheCroniclesOfFinnick.Models.Domain;

namespace TheCroniclesOfFinnick.Data
{
    public class FinnickCodingCroniclesDbContext : DbContext
    {
        public FinnickCodingCroniclesDbContext(DbContextOptions options) : base(options) 
        { }
    
        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }


    
    }
}
