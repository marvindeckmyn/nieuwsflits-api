using Microsoft.EntityFrameworkCore;
using NieuwsFlits.API.Models;

namespace NieuwsFlits.API.Data
{
    public class NewsContext: DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) : base(options) { }

        public DbSet<NewsArticle> NewsArticles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsArticle>()
                .Property(e => e.Tags)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
                );
        }
    }
}