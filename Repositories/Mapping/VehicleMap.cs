using FluentNHibernate.Mapping;
using Inventory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Mapping
{
    public class VehicleMap : ClassMap<Vehicle>
    {
        public VehicleMap()
        {
            Id(x => x.ID).UniqueKey("ID").Column("ID").GeneratedBy.Increment();
            Map(x => x.Make, "MAKE").CustomSqlType("NVARCHAR").Nullable();
            Map(x => x.Model, "MODEL").CustomSqlType("NVARCHAR").Not.Nullable();
            Map(x => x.Year, "YEAR").CustomSqlType("INTEGER").Not.Nullable();

        }
    }
}
