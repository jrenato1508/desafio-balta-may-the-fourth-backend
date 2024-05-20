using MayTheFourth.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Api.Data
{
    public class MinimalDbContext : DbContext
    {
        public MinimalDbContext(DbContextOptions<MinimalDbContext> options) : base(options){}

        #region DbSet das entidades
        public DbSet<Especies> Species { get; set; }
        public DbSet<Films> Films { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Planets> planet { get; set; }
        public DbSet<StarShips> StarShips { get; set; }
        public DbSet<Vehichles> Vehicles { get; set; }

        #endregion

        #region Mapeamento das entidades


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapeamento Especies
            modelBuilder.Entity<Especies>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Especies>()
                .Property(e => e.name)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.classification)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.designation)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.average_height)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.skin_colors)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.hair_colors)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.eye_colors)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.average_lifespan)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.homeworld)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.language)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.people)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.language)
                .IsRequired()
                .HasColumnType("varchar(512)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.created)
                .IsRequired()
                .HasColumnType("datetime2(7)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.edited)
                .IsRequired()
                .HasColumnType("datetime2(7)");

            modelBuilder.Entity<Especies>()
                .Property(e => e.url)
                .IsRequired()
                .HasColumnType("varchar(512)");
            #endregion

            #region Mapeamento Films
            modelBuilder.Entity<Films>()
                .HasKey(f => f.Id);

            modelBuilder.Entity<Films>()
                .Property(f => f.title)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Films>()
                .Property(f => f.episode_id)
                .IsRequired()
                .HasColumnType("int");

            modelBuilder.Entity<Films>()
                .Property(f => f.opening_crawl)
                .IsRequired()
                .HasColumnType("Varchar(512");

            modelBuilder.Entity<Films>()
                .Property(f => f.director)
                .IsRequired()
                .HasColumnType("Varchar(512");

            modelBuilder.Entity<Films>()
                .Property(f => f.producer)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Films>()
                .Property(f => f.release_date)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Films>()
                .Property(f => f.characters)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Films>()
                .Property(f => f.planets)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Films>()
                .Property(f => f.starships)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Films>()
                .Property(f => f.vehicles)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Films>()
                .Property(f => f.species)
                .IsRequired()
                .HasColumnType("Varchar(1000)");

            modelBuilder.Entity<Films>()
                .Property(f => f.created)
                .IsRequired()
                .HasColumnType("datetime2(7)");

            modelBuilder.Entity<Films>()
                .Property(f => f.edited)
                .IsRequired()
                .HasColumnType("datetime2(7)");

            modelBuilder.Entity<Films>()
                .Property(f => f.url)
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

            #region Mapeamento Planets
            modelBuilder.Entity<Planets>()
                .HasKey( p => p.Id );

            modelBuilder.Entity<Planets>()
                .Property(p => p.name)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.rotation_period)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.orbital_period)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.diameter)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.climate)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.gravity)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.terrain)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.surface_water)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.population)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.residents)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.films)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Planets>()
                .Property(p => p.url)
                .IsRequired()
                .HasColumnType("Varchar(512)");


            #endregion

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
                .HasColumnType("datetime2(7)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.edited)
                .IsRequired()
                .HasColumnType("datetime2(7)");

            modelBuilder.Entity<StarShips>()
                .Property(s => s.url)
                .IsRequired()
                .HasColumnType("Varchar(512)");
            #endregion

            #region Mapeamento Veiculos
            modelBuilder.Entity<Vehichles>()
               .HasKey(s => s.Id);

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.name)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.model)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.manufacturer)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.cost_in_credits)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.length)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.max_atmosphering_speed)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.crew)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.passengers)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.cargo_capacity)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.consumables)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.vehicle_class)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.pilots)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.films)
                .IsRequired()
                .HasColumnType("Varchar(512)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.created)
                .IsRequired()
                .HasColumnType("datetime2(7)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.edited)
                .IsRequired()
                .HasColumnType("datetime2(7)");

            modelBuilder.Entity<Vehichles>()
                .Property(s => s.url)
                .IsRequired()
                .HasColumnType("Varchar(512)");

           
            #endregion


            base.OnModelCreating(modelBuilder);
        }


        #endregion
    }
}
