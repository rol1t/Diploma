using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace diploma.Models
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TestTheme> TestThemes { get; set; }

        public Context()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=diploma;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Login)
                .IsUnique();
            modelBuilder.Entity<User>()
                .HasData(new User[]
                {
                    new User
                    {
                        Id = 1,
                        UserName = "Гарицкий Алексей",
                        Login = "rolitT",
                        Password = "123",
                        RoleId = 1
                    },
                    new User
                    {
                        Id = 2,
                        UserName = "Гарицкий Алексей",
                        Login = "rolitU",
                        Password = "123",
                        RoleId = 2
                    }
                });

            //Role
            modelBuilder.Entity<Role>()
                .HasData(new Role[]
                {
                    new Role { Id = 1, Name = "Учитель" },
                    new Role { Id = 2, Name = "Ученик" }
                });

            //Result
            modelBuilder.Entity<Result>()
                .HasOne(r => r.User)
                .WithMany(r => r.Results)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Result>()
                .HasOne(r => r.Test)
                .WithMany(r => r.Results)
                .HasForeignKey(r => r.TestId)
                .OnDelete(DeleteBehavior.Restrict);

            //TestThemes
            modelBuilder.Entity<TestTheme>()
                .HasOne(tt => tt.Test)
                .WithMany(tt => tt.TestThemes)
                .HasForeignKey(tt => tt.TestId);
            modelBuilder.Entity<TestTheme>()
                 .HasOne(tt => tt.Theme)
                 .WithMany(tt => tt.TestThemes)
                 .HasForeignKey(tt => tt.ThemeId);
            modelBuilder.Entity<TestTheme>()
                .HasKey(tt => new { tt.TestId, tt.ThemeId });
        }
    }
}
