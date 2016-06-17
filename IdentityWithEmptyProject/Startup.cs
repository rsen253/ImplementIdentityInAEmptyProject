using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;
using IdentityWithEmptyProject.Models;
using IdentityWithEmptyProject;


[assembly: OwinStartupAttribute(typeof(IdentityWithEmptyProject.Startup))]
namespace IdentityWithEmptyProject
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);
        }
    }
}