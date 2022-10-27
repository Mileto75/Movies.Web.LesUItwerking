using Microsoft.EntityFrameworkCore;
using Movies.Core.Entities;

namespace Movies.Web.Data
{
    public class MovieDbContext : DbContext
    {
        //Dbsets = tables
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //database configurations
            modelBuilder.Entity<Actor>()
                .Property(a => a.Firstname)
                .IsRequired()
                .HasMaxLength(120);
            modelBuilder.Entity<Actor>()
                .Property(a => a.Lastname)
                .IsRequired()
                .HasMaxLength(120);
            modelBuilder.Entity<Director>()
                .Property(a => a.Firstname)
                .IsRequired()
                .HasMaxLength(120);
            modelBuilder.Entity<Director>()
                .Property(a => a.Lastname)
                .IsRequired()
                .HasMaxLength(120);
            modelBuilder.Entity<Company>()
                .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(150);
            modelBuilder.Entity<Rating>()
                .Property(a => a.Score)
                .IsRequired();
            //set cascade rule to setnull
            modelBuilder.Entity<User>()
                .HasMany(u => u.Ratings)
                .WithOne(r => r.User)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}
