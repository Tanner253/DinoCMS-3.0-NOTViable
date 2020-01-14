using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffold_CMS.Models
{
    public class Dinosaur
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "This is my custom error message")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Cenrivore/Carnivore/Omnivore")]
        [Display(Name = "Diet")]
        public string Diet { get; set; }
        public string DinoProfile { get; set; }
        public string PackLimits { get; set; }

     
    }
}
