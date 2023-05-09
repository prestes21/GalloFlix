using GalloFlix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GalloFlix.Data;
  public class AppDbseed
    {
        public AppDbseed(ModelBuilder builder)
        {
            #region Popilate Roles - Perfis de Usuário
            List<IdentityRole> roles = new()
            {
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR",
                },
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Moderador",
                    NormalizedName = "MODERADOR",
                },
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Usuário",
                    NormalizedName = "USUÁRIO",
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
            #endregion

            #region Populate AppUser - Usuários
             List<AppUser> users = new()
            {
                new AppUser()
                {
                     Id = Guid.NewGuid().ToString(),
                     Name = "Bianca Pereira Prestes",
                     DateOfBirth = DateTime.Parse("21/02/2006"),
                     Email = "bianca2102prestes@gmail.com",
                     NormalizedEmail = "BIANCA2102PRESTES@GMAIL.COM",
                     UserName = " Wannabi",
                     NormalizedUserName = "WANNABI",
                     LockoutEnabled = false,
                     PhoneNumber = "1499645-8482",
                     PhoneNumberConfirmed = true,
                     EmailConfirmed = true,
                     ProfilePicture = "/img/users/avatar.png"
                }
            };
                foreach (var user in users)
                {
                     PasswordHasher<AppUser> pass = new();
                     user.PasswordHash = pass.HashPassword(user, "@Etec123");
                }
                 builder.Entity<AppUser>().HasData(users);
            

            #endregion
          
        #region Populate AppUser Role - Usuário e seu Perfil
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>()
                {
                    UserId = users[0].Id,
                    RoleId = roles[0].Id
                }
            };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
        }
    }
