using System;
using Microsoft.Owin;
using Owin;
using TheClassroom.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartupAttribute(typeof(TheClassroom.Startup))]
namespace TheClassroom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoles();
        }

        private void CreateRoles()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            var roleManager = new RoleManager<Role, int>(new RoleStore<Role, int, UserRole>(dbContext));
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser, Role, int, UserLogin, UserRole, UserClaim>(dbContext));

            if (!roleManager.RoleExists("SuperAdmin"))
            {
                var role = new Role();
                role.Name = "SuperAdmin";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "shade.it.stuff@gmail.com";
                user.Email = "shade.it.stuff@gmail.com";

                string userPWD = "admin123";

                var chkUser = manager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = manager.AddToRole(user.Id, "SuperAdmin");

                }
            }


            if (!roleManager.RoleExists("SchoolAdmin"))
            {
                var role = new Role();
                role.Name = "SchoolAdmin";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Student"))
            {
                var role = new Role();
                role.Name = "Student";
                roleManager.Create(role);
            }

        }
    }
}
