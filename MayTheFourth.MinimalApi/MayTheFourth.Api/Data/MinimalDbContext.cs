using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Api.Data
{
    public class MinimalDbContext : DbContext
    {
        public MinimalDbContext(DbContextOptions<MinimalDbContext> options) : base(options){}

        #region DbSet das entidades

        #endregion

        #region Mapeamento das entidades

        #endregion
    }
}
