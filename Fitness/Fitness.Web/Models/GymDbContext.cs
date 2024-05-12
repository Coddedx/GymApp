using Fitness.Web.Migrations;
//using Fitness.Web.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace GymApp.Web.Models {
    public class GymDbContext : DbContext {
        public GymDbContext() {

        }

        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<MainPage> MainPages { get; set; }
        public DbSet<BodyIndex> BodyIndexes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseUser> CourseUsers { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainerCategory> TrainerCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ContactMessage> ContactMessages  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-QT5SFJG4\\SQLEXPRESS;"
                // + "User Id=fatma;Password=12345;"
                + "Database=GymDb;Trusted_Connection=true;Encrypt=false;"
                );
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            //fluent validation
            modelBuilder.Entity<CourseUser>()
                .HasKey(c => new { c.CourseId, c.UserId });

            modelBuilder.Entity<TrainerCategory>()
              .HasKey(c => new { c.CategoryId, c.TrainerId });

            base.OnModelCreating(modelBuilder);
        }

    }
}
