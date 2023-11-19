using Microsoft.EntityFrameworkCore;

namespace AspNetSerwer.Data
{
    public sealed class AppDbContext : DbContext
    {
        public DbSet<Post>? Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ReactApp;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Post[] postsToSeed = new Post[7];

            for (int i = 1; i <= 7; i++)
            {
                postsToSeed[i - 1] = new Post
                {
                    Id = Guid.NewGuid(),
                    Title = $"Post {i}",
                    Content = $"This is post {i} and has some interesting content"
                };
            }
            
            modelBuilder.Entity<Post>().HasData(postsToSeed);
        }
    }
}
