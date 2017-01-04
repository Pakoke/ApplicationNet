using Inventory;
using Inventory.Dtos;
using Newtonsoft.Json;
using NHibernate;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using NHibernate.Linq;
using WebCommonApplication.Models;

namespace WebCommonApplication.Controllers
{
    public class InventoryController : Controller
    {

        ISessionFactory sessionFactory = MySqlSessionFactory.CreateSessionFactory();

        
        List<Vehicle> _vehiclestoreturn = new List<Vehicle>()
            {
                new Vehicle()
                {
                    Year = 1926,Make = "Chrysler",Model = "Imperial"
                        },
                        new Vehicle()
                {
                    Year = 1948,Make = "Citroën",Model = "2CV"
                        },
                        new Vehicle()
                {
                    Year = 1950,Make = "Hillman",Model = "Minx Magnificent"
                        }
        };


        // GET: Inventory
        public ActionResult Index()
        {
            int numPage = 0;
            int pageSize = 10;
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    _vehiclestoreturn = session.Query<Vehicle>().OrderByDescending(x => x.Year).Skip(numPage * pageSize).Take(pageSize).ToList();
                    transaction.Commit();
                }
            }

            ViewBag.Title = "Play with the title of the Inventory";
            
            ViewBag.ListOfVehicle = _vehiclestoreturn;
            return View();
        }


        [HttpPost]
        public JsonResult PostRemoveList(Vehicle jsondata)
        {
            _vehiclestoreturn.RemoveAll(v => v.Make == jsondata.Make && v.Model == jsondata.Model && v.Year == jsondata.Year);
            return Json(JsonConvert.SerializeObject(jsondata));
        }

        [HttpPost]
        public JsonResult PostEditList(int? id)
        {

            Stream req = Request.InputStream;
            req.Seek(0, System.IO.SeekOrigin.Begin);
            string json = new StreamReader(req).ReadToEnd();

            Vehicle input = null;
            try
            {
                // assuming JSON.net/Newtonsoft library from http://json.codeplex.com/
                input = JsonConvert.DeserializeObject<Vehicle>(json);

                //return Json(JsonConvert.SerializeObject(input));
            }
            catch (Exception ex)
            {
                // Try and handle malformed POST body
                return Json(new HttpStatusCodeResult(HttpStatusCode.BadRequest));
            }

            //using (var session = sessionFactory.OpenSession())
            //{
            //    using (var transaction = session.BeginTransaction())
            //    {
            //        // create a couple of Stores each with some Products and Employees


            //        // save both stores, this saves everything else via cascading
            //        session.SaveOrUpdate(barginBasin);
            //        session.SaveOrUpdate(superMart);

            //        transaction.Commit();
            //    }
            //}

                return null;


            //Vehicle model = JsonConvert.DeserializeObject<Vehicle>(jsondata);

            //var vehicleRecovered = _vehiclestoreturn.FirstOrDefault(v => v.Make == model.Make && v.Model == model.Model && v.Year == model.Year);

            //_vehiclestoreturn.Remove(model);

            
        }
    }
    
}