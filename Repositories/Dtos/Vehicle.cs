using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Dtos
{
    public class Vehicle : IVehicle
    {
        [Display(AutoGenerateField = true)]
        public virtual int ID { get; set; }

        
        [Required]
        public virtual int Year { get; set; }

 
        public virtual string Make { get; set; }

        [Required]
        public virtual string Model { get; set; }

        public Vehicle()
        {

        }
    }
}
