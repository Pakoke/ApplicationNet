using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Dtos
{
    public class Car
    {
        public string ID { get; set; }

        [Display(Name = "Año")]
        [Required]
        public int Year { get; set; }

        [Display(Name = "Hecho por:")]
        public string Make { get; set; }

        [Display(Name = "Modelo")]
        [Required]
        public string Model { get; set; }

        public Car()
        {

        }
    }
}
