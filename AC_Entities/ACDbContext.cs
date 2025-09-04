using AC_Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AC_Entities
{
    public class ACDbContext : DbContext
    {
        public ACDbContext(DbContextOptions<ACDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
