using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Data
{
    public class TestProjectContext : DbContext
    {
        public TestProjectContext(DbContextOptions<TestProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Name> Names { get; set; } = null!;
    }
}
