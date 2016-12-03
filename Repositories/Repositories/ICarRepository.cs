using Inventory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories
{
    interface ICarRepository : IRepository
    {
        List<Car> getAllCars();
    }
}
