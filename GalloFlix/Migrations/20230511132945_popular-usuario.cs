using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalloFlix.Migrations
{
    public partial class popularusuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "015078d3-f9c8-4d20-862d-c4c30dfd82cf", "706d7f06-cc90-4cd0-8fd4-eed02d4eb938", "Administrador", "ADMINISTRADOR" },
                    { "694468e2-5a9f-4f19-80ee-7bb4dd87a623", "4aca7d01-b984-4bf8-b03e-65a19d1086f9", "Usuário", "USUÁRIO" },
                    { "f37ba23c-309a-4863-8cfb-503131e9fcd1", "433ef22f-a14a-4800-bf7f-35a2b8c59d22", "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96e5a1da-6a3a-4ded-8eeb-77526182bd0a", 0, "466445b1-004a-41a2-a2b0-91288740624f", new DateTime(2006, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "bianca2102prestes@gmail.com", true, false, null, "Bianca Pereira Prestes", "BIANCA2102PRESTES@GMAIL.COM", "WANNABI", "AQAAAAEAACcQAAAAEF9hPZ4H053XuRI0cntgz8+Gas5pFFcjKhFofiCfROlrxvd/sN/umQG69UpRHHWkHQ==", "1499645-8482", true, "/img/users/avatar.png", "a4ff7268-cb83-4654-8e73-a031f28ab1a5", false, " Wannabi" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "015078d3-f9c8-4d20-862d-c4c30dfd82cf", "96e5a1da-6a3a-4ded-8eeb-77526182bd0a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "694468e2-5a9f-4f19-80ee-7bb4dd87a623");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f37ba23c-309a-4863-8cfb-503131e9fcd1");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "015078d3-f9c8-4d20-862d-c4c30dfd82cf", "96e5a1da-6a3a-4ded-8eeb-77526182bd0a" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "015078d3-f9c8-4d20-862d-c4c30dfd82cf");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "96e5a1da-6a3a-4ded-8eeb-77526182bd0a");
        }
    }
}
