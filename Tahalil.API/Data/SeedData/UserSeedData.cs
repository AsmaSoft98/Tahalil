using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Tahalil.API.Data.SeedData
{
    public class UserSeedData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Name)
                    .HasMaxLength(60);
            builder.Property(e => e.Email)
                   .HasMaxLength(100);

           
            CreatePasswordHash("Azerty-123", out byte[] passwordHash, out byte[] passwordSalt);
            List<User> users;
            users = new List<User> {
                new User {Id = 1,Name = "Patient1", Email = "Patient1@gmail.com", PasswordHash = passwordHash,
                                 PasswordSalt = passwordSalt, Role = UserRole.Admin},
                new User {Id = 2,Name = "Prescript1", Email = "Prescript1@gmail.com", PasswordHash = passwordHash,
                                 PasswordSalt = passwordSalt, Role = UserRole.Prescript},
                new User {Id = 3,Name = "Prescript2", Email = "Prescript2@gmail.com", PasswordHash = passwordHash,
                                 PasswordSalt = passwordSalt, Role = UserRole.Prescript},
                new User {Id = 4,Name = "Patient2", Email = "Patient2@gmail.com", PasswordHash = passwordHash,
                                 PasswordSalt = passwordSalt, Role = UserRole.Patient},
                new User {Id = 5,Name = "Patient3", Email = "Patient3@gmail.com", PasswordHash = passwordHash,
                                 PasswordSalt = passwordSalt, Role = UserRole.Patient},
                new User {Id = 6,Name = "Patient4", Email = "Patient4@gmail.com", PasswordHash = passwordHash,
                                 PasswordSalt = passwordSalt, Role = UserRole.Patient},

            };

            builder.HasData(users);
        }
        private void CreatePasswordHash(string password,
                                        out byte[] passwordhash,
                                        out byte[] passwordsalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordsalt = hmac.Key;
                passwordhash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
