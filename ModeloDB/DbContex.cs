using System;
using Microsoft.EntityFrameworkCore;
using Modelo.Peliculas;
namespace ModeloDB

{
    public class Class1 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BFT9R9J;Database=EFCore-MoviesDB;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //1 a muchos 
            modelBuilder.Entity<film>()
               .HasOne(c => c.language)
               .WithMany(m => m.films)
               .HasForeignKey(c => c.CurrentMovie);

            modelBuilder.Entity<inventory>()
              .HasOne(c => c.film)
              .WithMany(m => m.inventories)
              .HasForeignKey(c => c.CurrentFilmid);
        }
        //Declaracion de clases 
        public DbSet<film> films { get; set; }
        public DbSet<language> languages { get; set; }
        public DbSet<inventory> inventories { get; set; }
    }
    
}
