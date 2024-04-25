using MayTheFourth.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Api.Data
{
    public class MinimalDbContext : DbContext
    {
        public MinimalDbContext(DbContextOptions<MinimalDbContext> options) : base(options){}

        #region DbSet das entidades
        public DbSet<StarShips> StarShips { get; set; }
        #endregion

        #region Mapeamento das entidades

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapeamento StarShips
            modelBuilder.Entity<StarShips>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<StarShips>()
                .Property(s => s.name)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.model)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.manufacturer)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.cost_in_credits)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.length)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.max_atmosphering_speed)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.crew)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.passengers)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.cargo_capacity)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.consumables)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.hyperdrive_rating)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.consumables)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.hyperdrive_rating)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.MGLT)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.starship_class)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.pilots)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.films)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.created)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.edited)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.url)
                .IsRequired()
                .HasColumnType("Varchar(512)");
            #endregion

            base.OnModelCreating(modelBuilder);
        }


        #endregion
    }
}
