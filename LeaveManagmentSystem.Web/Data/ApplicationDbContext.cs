using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagmentSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole {
                    Id = "34cead93-0c51-4f32-81bf-862146329086",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole {
                    Id = "a959a7bd-d272-43b2-bfe3-20da89081dc3",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole {
                    Id = "a4d3ecb7-1ea0-4e40-bc5a-fdc516bfbad8",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "ca89511a-f9ce-45af-8d7e-a2a3cf47cf8e",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(2000,12,12)
            });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> 
                {
                    RoleId = "a4d3ecb7-1ea0-4e40-bc5a-fdc516bfbad8",
                    UserId = "ca89511a-f9ce-45af-8d7e-a2a3cf47cf8e"
                }
                );
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
