using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffold_CMS.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Authorized { get; set; } = "false";

    }

    public static class ApplicationRoles
    {
        public const string Member = "Member";
        public const string Admin = "ADMIN";
    }
}
