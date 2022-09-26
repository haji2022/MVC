using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using MVC.ViewModels;
using System.Reflection.Emit;
namespace MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        { }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        { }


        public DbSet<Country> Countries { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Language> Languages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Italy" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 2, Name = "Sweden" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 3, Name = "Angola" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 4, Name = "Spain" });


            modelBuilder.Entity<City>().HasData(new City { Id = 1, Name = "Roma", CountryId = 1 });
            modelBuilder.Entity<City>().HasData(new City { Id = 2, Name = "Stockholm", CountryId = 2 });
            modelBuilder.Entity<City>().HasData(new City { Id = 3, Name = "Kinsasha", CountryId = 3 });
            modelBuilder.Entity<City>().HasData(new City { Id = 4, Name = "Madrid", CountryId = 4 });


            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Peter Schumacher", Phone = "123456789", CityId = 1 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 2, Name = "Faire Fanny", Phone = "234567890", CityId = 1 });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 3, Name = "Nicky Lauda", Phone = "345678912", CityId = 1 });

            modelBuilder.Entity<Language>().HasData(new Language { LangId = 1, Name = "Arabic" });
            modelBuilder.Entity<Language>().HasData(new Language { LangId = 2, Name = "Spanish" });
            modelBuilder.Entity<Language>().HasData(new Language { LangId = 3, Name = "English" });
            modelBuilder.Entity<Language>().HasData(new Language { LangId = 4, Name = "Somali" });


            modelBuilder.Entity<Person>()
               .HasMany(p => p.Languages)
               .WithMany(l => l.People)
               .UsingEntity(j => j.HasData(new { LanguagesLangId = 1, PeopleId = 1 }));


            modelBuilder.Entity<Person>()
                 .HasMany(p => p.Languages)
                 .WithMany(l => l.People)
                 .UsingEntity(j => j.HasData(new { LanguagesLangId = 1, PeopleId = 2 }));
            modelBuilder.Entity<Person>()
                .HasMany(p => p.Languages)
                .WithMany(l => l.People)
                .UsingEntity(j => j.HasData(new { LanguagesLangId = 1, PeopleId = 3 }));

            // it depends how many people you have in the list


            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"
            });

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "Admin",
                LastName = "Adminsson",
                DateOfBirth = DateTime.Now,
                PasswordHash = hasher.HashPassword(null, "password")
            }); ;

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = userId
            });
        }
    }
    }
