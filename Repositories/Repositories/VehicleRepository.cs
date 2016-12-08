using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Dtos;

namespace Inventory.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> getAllVehicles()
        {
            return new List<Vehicle>();
        }
    }
}
