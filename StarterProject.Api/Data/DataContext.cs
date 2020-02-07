using Microsoft.EntityFrameworkCore;
using StarterProject.Api.Common;
using StarterProject.Api.Data.Entites;
using StarterProject.Api.Features.Users;
using StarterProject.Api.Security;

namespace StarterProject.Api.Data
{
    public class Token {
        public int Id { get; set; }
        public string Value { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Token> Tokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHash("admin");
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Role = Constants.Users.Roles.Admin,
                    Username = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Seeded-Admin-FirstName",
                    LastName = "Seeded-Admin-LastName",
                    Address = "Seeded-Admin-Adress",
                    City = "Seeded-Admin-City",
                    State = "Seeded-Admin-State",
                    ZipCode = "Seeded-Admin-ZipCode",
                    PhoneNumber = "Seeded-Admin-PhoneNumber",
                    PasswordHash = passwordHasher.Hash,
                    PasswordSalt = passwordHasher.Salt
                });
                
            modelBuilder.Entity<Availability>();
            modelBuilder.Entity<Schedule>();
            modelBuilder.Entity<Position>().HasData(
            //Create Manager
                new Position
                {
                    Id = 1,
                    Name = "Manager"
                },

            //Create Host
                new Position
                {
                    Id = 2,
                    Name = "Host"
                },

            //Create Waiter
                new Position
                {
                    Id = 3,
                    Name = "Waiter"
                },

            //Create Bartender
                new Position
                {
                    Id = 4,
                    Name = "Bartender"
                },

            //Create Busser
                new Position
                {
                    Id = 5,
                    Name = "Busser"
                });
        }
    }
}
