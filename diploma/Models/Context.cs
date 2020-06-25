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

            //Subject
            modelBuilder.Entity<Subject>()
                .HasData(new Subject[]
                {
                    new Subject 
                    { 
                        Id = 1,
                        Name = "Технологии разработки программного обеспечения",
                        Alias = "ТРПО"
                    },
                    new Subject
                    {
                        Id = 2,
                        Name = "Защита компьютерной информации",
                        Alias = "ЗКИ"
                    },
                    new Subject
                    {
                        Id = 3,
                        Name = "СПО",
                        Alias = "Системное программное обеспечение"
                    },
                    new Subject
                    {
                        Id = 4,
                        Name = "БДиСУБД",
                        Alias = "Базы данных и систему управления базами данных"
                    },
                    new Subject
                    {
                        Id = 5,
                        Name = "Основы алгоритмизации и программирования",
                        Alias = "ОАИП"
                    },
                    new Subject
                    {
                        Id = 6,
                        Name = "Компьютерные сети",
                        Alias = "КС"
                    },
                    new Subject
                    {
                        Id = 7,
                        Name = "Программные средства интренет приложений",
                        Alias = "ПСИП"
                    },
                    new Subject
                    {
                        Id = 8,
                        Name = "Автоматизация управленческой деятельности предприятия",
                        Alias = "АУДП"
                    },
                    new Subject
                    {
                        Id = 9,
                        Name = "Тестирование и отладка программного обеспечения",
                        Alias = "ТиОПО"
                    },
                    new Subject
                    {
                        Id = 10,
                        Name = "Конструирование программ и языки программирования",
                        Alias = "КПиЯП"
                    },
                });
        }
    }
}
