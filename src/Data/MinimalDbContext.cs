using MayTheFourth.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Api.Data
{
    public class MinimalDbContext : DbContext
    {
        public MinimalDbContext(DbContextOptions<MinimalDbContext> options) : base(options){}

        #region DbSet das entidades
        public DbSet<Vehicle> Vehicles { get; set; }
        #endregion

        #region Mapeamento das entidades

        #endregion
    }
}
