using EventApi.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace EventApi
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "_Aa123456";
            if (await roleManager.FindByNameAsync("User") == null)
            {
                await roleManager.CreateAsync(new ApplicationRole("User"));
            }
            if (await roleManager.FindByNameAsync("Admin") == null)
            {
                await roleManager.CreateAsync(new ApplicationRole("Admin"));
            }
            if (await roleManager.FindByNameAsync("Moderator") == null)
            {
                await roleManager.CreateAsync(new ApplicationRole("Moderator"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                DateTime dateTime = DateTime.Now;
                ApplicationUser admin = new ApplicationUser { Email = adminEmail, UserName = adminEmail, FirstName = "Admin", Created = dateTime };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                    await userManager.AddToRoleAsync(admin, "User");
                }
            }
        }
    }
}
