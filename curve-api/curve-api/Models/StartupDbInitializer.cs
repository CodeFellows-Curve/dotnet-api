using curve_api.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curve_api.Models
{
    public class StartupDbInitializer
    {
        private static List<IdentityRole> Roles = new List<IdentityRole>
        {
            new IdentityRole {Name = ApplicationRoles.Admin, NormalizedName = ApplicationRoles.Admin.ToUpper()},
            new IdentityRole {Name = ApplicationRoles.Manager, NormalizedName = ApplicationRoles.Manager.ToUpper()},
            new IdentityRole {Name = ApplicationRoles.SuperUser, NormalizedName = ApplicationRoles.SuperUser.ToUpper()},
            new IdentityRole {Name = ApplicationRoles.User, NormalizedName = ApplicationRoles.User.ToUpper()}
        };

        public static void SeedData(IServiceProvider serviceProvider)
        {
            using (var dbContext = new CurveUserDbContext(serviceProvider.GetRequiredService<DbContextOptions<CurveUserDbContext>>()))
            {
                dbContext.Database.EnsureCreated();

                if (dbContext.Roles.Any()) return;

                else
                {
                    dbContext.Roles.AddRange(Roles);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
