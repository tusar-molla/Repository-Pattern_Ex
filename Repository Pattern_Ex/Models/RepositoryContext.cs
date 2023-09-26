using Microsoft.EntityFrameworkCore;

namespace Repository_Pattern_Ex.Models
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Account> Accounts { get; set; }
        

    }
}

