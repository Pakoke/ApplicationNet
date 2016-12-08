using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Inventory.Dtos;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.NHibernate
{
    public class SessionFactory
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c=>c.FromAppSetting("connectionString")))
                  .Mappings(m =>
                    m.AutoMappings.Add(
                      // your automapping setup here
                      AutoMap.AssemblyOf<Vehicle>(type => type.Namespace.EndsWith("Inventory"))))
                  .BuildSessionFactory();
        }
    }
}
