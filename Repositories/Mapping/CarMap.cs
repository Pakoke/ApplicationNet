using FluentNHibernate.Mapping;
using Inventory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Mapping
{
    public class CarMap : ClassMap<Car>
    {
        public CarMap()
        {
            Id(x => x.ID).UniqueKey("ID").Column("ID").GeneratedBy.Identity();
            Map(x => x.Make, "MAKE").CustomSqlType("NVARCHAR").Nullable();
            Map(x => x.Model, "MODEL").CustomSqlType("NVARCHAR").Not.Nullable();
            Map(x => x.Year, "YEAR").CustomSqlType("INTEGER").Not.Nullable();

        }
    }
}
