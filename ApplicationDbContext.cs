using Microsoft.EntityFrameworkCore;

namespace ContactManagementApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Adicione DbSet para suas entidades aqui
        public DbSet<Contact> Contacts { get; set; } // Exemplo de DbSet para a entidade Contact
    }
}
