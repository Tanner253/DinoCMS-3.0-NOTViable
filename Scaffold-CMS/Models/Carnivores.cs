using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffold_CMS.Models
{
    public class Carnivores
    {
        public int DinosaurID { get; set; }
        public string Name { get; set; }
        /*
        public string Rules { get; set; }
        public string Details { get; set; }
        public string Profile { get; set; }
        */

        //navigation
        public Dinosaur Dinosaur { get; set; }

    }
}
