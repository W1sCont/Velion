using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure.EF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MediaContent> MediaContents { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<UserFavorite> UserFavorites { get; set; }
        public DbSet<ContentReaction> ContentReactions { get; set; }
        public DbSet<WatchHistory> WatchHistories { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(
                    e =>
                    {
                        e.Property(x => x.Email).HasMaxLength(256);
                        e.HasIndex(x => x.Email).IsUnique();
                        e.Property(x => x.Nickname).HasMaxLength(50);
                        e.HasIndex(x => x.Nickname).IsUnique();
                        e.Property(x => x.Phone).HasMaxLength(20);
                        e.HasIndex(x => x.Phone).IsUnique();
                    });

            modelBuilder.Entity<Genre>(
                    e =>
                    {
                        e.Property(x => x.Name).HasMaxLength(256);
                        e.HasIndex(x => x.Name).IsUnique();
                    });

            modelBuilder.Entity<MediaContent>(
                    e =>
                    {
                        e.HasDiscriminator<string>("ContentType").HasValue<Movie>("Movie").HasValue<Series>("Series");
                        e.Property(x => x.Name).HasMaxLength(256);
                    });

            modelBuilder.Entity<Season>(
                    e =>
                    {
                        e.HasIndex(x => new { x.SeriesId, x.SeasonNumber }).IsUnique();
                    });

            modelBuilder.Entity<Episode>(
                    e =>
                    {
                        e.HasIndex(x => new { x.SeasonId, x.EpisodeNumber }).IsUnique();
                    });

            modelBuilder.Entity<UserFavorite>(
                    e =>
                    {
                        e.HasKey(x => new { x.UserId, x.MediaContentId });
                    });

            modelBuilder.Entity<ContentReaction>(
                    e =>
                    {
                        e.HasKey(x => new { x.UserId, x.MediaContentId });
                    });

            modelBuilder.Entity<WatchHistory>(
                    e =>
                    {
                        e.HasKey(x => new { x.UserId, x.MediaContentId });
                        e.HasOne(x => x.Episode).WithMany().HasForeignKey(x => x.EpisodeId).OnDelete(DeleteBehavior.NoAction);
                    });
        }


    }

}
