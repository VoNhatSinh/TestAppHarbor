using DoAnCuoiKy.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnCuoiKy.Logic
{
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            Models.ApplicationDbContext db = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            var roleStore = new RoleStore<IdentityRole>(db);

            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }

            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var appUser = new ApplicationUser
            {
                UserName = "nhatsinh18@gmail.com",
                Email = "nhatsinh18@gmail.com"
            };
            IdUserResult = userMgr.Create(appUser, "NhatSinh123*");

            if (!userMgr.IsInRole(userMgr.FindByEmail("nhatsinh18@gmail.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("nhatsinh18@gmail.com").Id, "canEdit");
            }
        }
    }
}