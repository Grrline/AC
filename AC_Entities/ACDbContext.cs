using AC_Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AC_Entities
{
    public class ACDbContext : DbContext
    {
        public ACDbContext(DbContextOptions<ACDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Resume> Resumes { get; set; }
    }
}