using Microsoft.EntityFrameworkCore;

namespace projectNew.Models
{
    public class dbContext : DbContext
    {

        public dbContext(DbContextOptions<dbContext> options) : base(options)
        { }

        public DbSet<Info> Infos { get; set; }
        public DbSet<Nation> Nations { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public DbSet<PreDistrict> PreDistricts { get; set; }
        public DbSet<ParDistrict> ParDistricts { get; set; }
        public DbSet<Blood> Bloods { get; set; }
        public DbSet<Desig> Desigs { get; set; }
        public DbSet<Compa> Compas { get; set; }
        public DbSet<Dept> Depts { get; set; }



        //public DbSet<> {get; set; }





    }
}
