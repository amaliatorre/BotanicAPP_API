using BotanicAPI.Entities.Avatar;
using BotanicAPI.Entities.Color;
using BotanicAPI.Entities.Milestone;
using BotanicAPI.Entities.Profile;
using BotanicAPI.Entities.Route;
using BotanicAPI.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace BotanicAPI.DataContext
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        #region DbContext
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProfileEntity> ProfileEntities { get; set; }
        public DbSet<ColorEntity> ColorEntities { get; set; }
        public DbSet<AvatarEntity> AvatarEntities { get; set; }
        public DbSet<UserMilestonesEntity> UserMilestonesEntities { get; set; }
        public DbSet<RouteEntity> RouteEntities { get; set; }
        public DbSet<MilestoneEntity> MilestoneEntities { get; set; }

        #endregion

        #region ModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<ProfileEntity>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<RouteEntity>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<MilestoneEntity>()
                .HasKey(x => x.Id);
        }
        #endregion

    }
}
