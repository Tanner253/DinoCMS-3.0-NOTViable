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

        [Required(ErrorMessage = "Please make a valid entry")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Carnivore/Herbivore/Omnivore")]
        [Display(Name = "Diet")]
        public string Diet { get; set; }

        [Required(ErrorMessage = "Please make a valid entry")]
        [Display(Name = "Need to know")]
        public string NeedToKnow { get; set; }

        [Required(ErrorMessage = "Please make a valid entry")]
        public string Behavior { get; set; }

        [Required(ErrorMessage = "Please make a valid entry")]
        [Display(Name = "Social Interaction")]
        public string SocialInteraction { get; set; }

        public string PackLimits { get; set; }
        public string Image { get; set; }

        public string Additionalinfo { get; set; } = "null";

     
    }
}
