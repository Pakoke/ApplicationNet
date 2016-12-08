using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Dtos
{
    public class Vehicle
    {
        [Display(AutoGenerateField = true)]
        public string ID { get; set; }

        
        [Required]
        public int Year { get; set; }

 
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public Vehicle()
        {

        }
    }
}
