
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.SqlServer.Management.Smo;
using Scaffold_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffold_CMS.Data
{
    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    //{

      
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    // Customize the ASP.NET Identity model and override the defaults if needed.
        //    // For example, you can rename the ASP.NET Identity table names and more.
        //    // Add your customizations after calling base.OnModelCreating(builder);

        //    // For Guid Primary Key
        //    builder.Entity<ApplicationUser>().Property(p => p.Id).ValueGeneratedOnAdd();

        //    // For int Primary Key
        //    //builder.Entity<ApplicationUser>().Property(p => p.Id).UseSqlServerIdentityColumn();
        //}
    //}

}
