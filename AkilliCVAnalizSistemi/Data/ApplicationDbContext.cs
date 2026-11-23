using Microsoft.EntityFrameworkCore;
using AkilliCVAnalizSistemi.Models;

namespace AkilliCVAnalizSistemi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<CV> CVler { get; set; }
        public DbSet<IsIlan> IsIlanlari { get; set; }
        public DbSet<AnalizSonuc> AnalizSonuclari { get; set; }
    }
}