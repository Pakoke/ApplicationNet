using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using Inventory.Dtos;
using Shared.NHibernate;
using Inventory;
using NHibernate;
using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;

namespace InventoryTest
{
    [TestClass]
    public class InventoryTest
    {
        private TestContext testContextInstance;
        private IContainer container;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        public InventoryTest()
        {
            //Register manually all classes
            container = new Container(c =>
            {
                c.For<IVehicle>().Use<Vehicle>();
            });

            //Scan all classes and register by itself
            //container = new Container(c =>
            //{
            //    c.Scan(scanner =>
            //    {
            //        scanner.Assembly("Inventory");
            //        scanner.WithDefaultConventions();
            //    });
            //});

        }

        [TestMethod]
        public void TestInventoryAccess()
        {
            Vehicle veh = (Vehicle)container.GetInstance<IVehicle>();

            veh.Make = "Ireland";
            veh.Model = "Ford";
            veh.Year = 1956;
        }

        [TestMethod]
        public void GetAllInventoryItems()
        {
            ISessionFactory sessionFactory = MySqlSessionFactory.CreateSessionFactory();
            List<Vehicle> _vehiclestoreturn = new List<Vehicle>();
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    _vehiclestoreturn = session.Query<Vehicle>().ToList();
                    transaction.Commit();
                }
            }

            CollectionAssert.AllItemsAreInstancesOfType(_vehiclestoreturn, typeof(Vehicle));
        }

    }
}
