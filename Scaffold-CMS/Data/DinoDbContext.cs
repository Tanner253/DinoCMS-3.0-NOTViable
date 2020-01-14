using Microsoft.EntityFrameworkCore;
using Scaffold_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffold_CMS.Data
{
    public class DinoDbContext : DbContext
    {
        public DinoDbContext(DbContextOptions<DinoDbContext> options) : base(options)
        {


        }

        //public DbSet<MODELNAME> TABLENAME { get; set; }
        public DbSet<Dinosaur> Dinosaur { get; set; }
        /*public DbSet<Dinosaur> Omnivore { get; set; }
        public DbSet<Dinosaur> Carnivore { get; set; }
        public DbSet<Dinosaur> Herbivore { get; set; }*/

    }
}
