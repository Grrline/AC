using AC_Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AC_Entities
{
    public class ACDbContext : DbContext
    {
        public ACDbContext(DbContextOptions<ACDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Resume> Resumes { get; set; }
    }
}