using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using IdentityWithEmptyProject.Models;
using Microsoft.AspNet.Identity.Owin;

namespace IdentityWithEmptyProject.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var email = "rsen253@gmail.com";
            var password = "Rahul@123";
            var user = await UserManager.FindByEmailAsync(email);

            if (user == null)
            {
                user = new CustomeUser
                {
                    UserName = email,
                    Email = email,
                    FirstName = "Super",
                    LastName = "Admin"
                };
                await UserManager.CreateAsync(user, password);
            }
            else
            {
                var result = await SignInManager.PasswordSignInAsync(user.UserName,password,true,false);
                if (result == SignInStatus.Success)
                {
                    return Content("Hello, " + user.FirstName + " " + user.LastName);
                }
                //user.FirstName = "Super";
                //user.LastName = "Admin";

                //await manager.UpdateAsync(user);
            }
            return Content("Hello World!!");
        }
    }
}