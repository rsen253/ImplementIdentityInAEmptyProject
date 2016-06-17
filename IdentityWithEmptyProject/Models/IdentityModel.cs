using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityWithEmptyProject.Models
{
    public class ApplicationDbContext : IdentityDbContext<CustomeUser>
    {
        public ApplicationDbContext() : base()
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    public class CustomeUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}