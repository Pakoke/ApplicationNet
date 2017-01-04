using Inventory.Dtos;
using Shared.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories
{
    interface IVehicleRepository
    {
        List<Vehicle> getAllVehicles();
    }
}
