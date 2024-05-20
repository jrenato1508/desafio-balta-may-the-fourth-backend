using MayTheFourth.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Api.Data
{
    public class MinimalDbContext : DbContext
    {
        public MinimalDbContext(DbContextOptions<MinimalDbContext> options) : base(options){}

        #region DbSet das entidades
        public DbSet<StarShips> StarShips { get; set; }
        public DbSet<People> Peoples { get; set; }
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

            #region Mapeamento People
            modelBuilder.Entity<People>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<People>()
                .Property(p => p.name)
                .IsRequired()
                .HasColumnType("Varchar(100)");

            modelBuilder.Entity<People>()
                .Property(p => p.height)
                .IsRequired()
                .HasColumnType("Varchar(100)");

            modelBuilder.Entity<People>()
                .Property(p => p.mass)
                .IsRequired()
                .HasColumnType("Varchar(100)");

            modelBuilder.Entity<People>()
                .Property(p => p.hair_color)
                .IsRequired()
                .HasColumnType("Varchar(100");

            modelBuilder.Entity<People>()
                .Property(p => p.skin_color)
                .IsRequired()
                .HasColumnType("Varchar(100)");

            modelBuilder.Entity<People>()
                .Property(p => p.birth_year)
                .IsRequired()
                .HasColumnType("Varchar(100)");

            modelBuilder.Entity<People>()
                .Property(p => p.gender)
                .IsRequired()
                .HasColumnType("Varchar(100)");

            modelBuilder.Entity<People>()
                .Property(p => p.homeworld)
                .IsRequired()
                .HasColumnType("Varchar(100)");

            modelBuilder.Entity<People>()
                .Property(p => p.films)
                .IsRequired()
                .HasColumnType("Varchar(1000)");

            modelBuilder.Entity<People>()
                .Property(p => p.species)
                .IsRequired()
                .HasColumnType("Varchar(1000)");

            modelBuilder.Entity<People>()
                .Property(p => p.starships)
                .IsRequired()
                .HasColumnType("Varchar(1000)");


            modelBuilder.Entity<People>()
                .Property(p => p.created)
                .IsRequired()
                .HasColumnType("Datetime2(7)");

            modelBuilder.Entity<People>()
                .Property(p => p.edited)
                .IsRequired()
                .HasColumnType("Datetime2(7)");

            modelBuilder.Entity<People>()
                .Property(p => p.url)
                .IsRequired()
                .HasColumnType("Varchar(100");

            #endregion

            base.OnModelCreating(modelBuilder);
        }


        #endregion
    }
}
