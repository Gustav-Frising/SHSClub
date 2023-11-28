using Microsoft.EntityFrameworkCore;
using SHSClub.Models;

namespace SHSClub.Database
{
    public class SHSClubDbContext : DbContext
    {
        public SHSClubDbContext()
        {

        }

        public DbSet<SuperheroModel> Superheroes { get; set; }
        public DbSet<SuperpowerModel> Superpowers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SHSClubDb;Trusted_Connection=True");
        }
    }
}
