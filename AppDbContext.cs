using Microsoft.EntityFrameworkCore;

namespace ContactManagementApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Adicione DbSet para suas entidades aqui
        // public DbSet<SuaEntidade> NomeDaEntidade { get; set; }
    }
}
