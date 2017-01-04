using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Dtos;
using NHibernate;
using Shared.NHibernate;

namespace Inventory.Repositories
{
    public class VehicleRepository : Repository<Vehicle>,IVehicleRepository
    {
        public VehicleRepository(ISession session) : base(session)
        {
        }

        public List<Vehicle> getAllVehicles()
        {
            return new List<Vehicle>();
        }
    }
}
