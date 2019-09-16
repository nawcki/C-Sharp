using System.Data.Entity;


namespace Locadora.Models
{
    public class DatabaseMovie : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
    }
}