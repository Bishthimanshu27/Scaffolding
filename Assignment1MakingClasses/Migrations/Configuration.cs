namespace Assignment1MakingClasses.Migrations
{
    using Assignment1MakingClasses.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment1MakingClasses.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Assignment1MakingClasses.Models.ApplicationDbContext";
        }

        protected override void Seed(Assignment1MakingClasses.Models.ApplicationDbContext context)
        {
            ApplicationUser adminUser = null;
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            adminUser = new ApplicationUser();
            adminUser.UserName = "admin@gmail.com";
            adminUser.Email = "admin@gmail.com";
            userManager.Create(adminUser, "Password-1");
        }
    }
}
