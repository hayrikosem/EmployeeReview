using EmployeeReview.Domain.Models.Entities;
using Infrastructure.Services.Persistance;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infrastructure;

public class SeedData
{
    public async Task Seed(AppDbContext context)
    {
        context.Database.EnsureCreated();

        // Seed default admin user with admin role
        if (!await context.Users.AnyAsync())
        {
            var userManager = context.GetService<UserManager<ApplicationUser>>();
            var roleManager = context.GetService<RoleManager<ApplicationRole>>();

            var adminRole = new ApplicationRole { Name = "Admin" };
            await roleManager.CreateAsync(adminRole);

            var adminUser = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@example.com",
                FirstName = "Admin",
                LastName = "User",
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(adminUser, "Pass123$");

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(adminUser, adminRole.Name);
            }
        }
    }
}