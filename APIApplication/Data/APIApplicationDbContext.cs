using APIApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace APIApplication.Data
{
    public class APIApplicationDbContext : DbContext
    {
        // To create Constructor
        public APIApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
