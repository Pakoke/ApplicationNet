using Inventory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories
{
    interface IVehicleRepository : IRepository
    {
        List<Vehicle> getAllVehicles();
    }
}
