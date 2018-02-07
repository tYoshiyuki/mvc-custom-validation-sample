using System.Data.Entity;

namespace MvcCustomValidation.Models
{
    public class MvcCustomValidationContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}