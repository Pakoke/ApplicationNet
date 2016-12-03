using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Dtos;

namespace Inventory.Repositories
{
    public class CarRepository : ICarRepository
    {
        public List<Car> getAllCars()
        {
            return new List<Car>();
        }
    }
}
