using Microsoft.EntityFrameworkCore;
using Cloudberry.Models;

namespace Cloudberry.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<MoodEntry> MoodEntries { get; set; }
        public DbSet<JournalEntry> JournalEntries {get; set;}
        public DbSet<CloudCompanion> CloudCompanions {get; set;}
    }
}
