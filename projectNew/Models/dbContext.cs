using Microsoft.EntityFrameworkCore;

namespace projectNew.Models
{
    public class dbContext:DbContext
    {

        public dbContext(DbContextOptions<dbContext> options) : base(options)
        { }

        public DbSet<Info> Infos { get; set; }
        public DbSet<Nation> Nations { get; set; }


    }
}
