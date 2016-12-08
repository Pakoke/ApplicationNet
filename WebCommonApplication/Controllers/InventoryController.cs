using Inventory.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebCommonApplication.Models;

namespace WebCommonApplication.Controllers
{

    public class VehicleData
    {
        public string Year;
        public string Make;
        public string Model;
    }
    
    public class InventoryController : Controller
    {
        
        
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

            ViewBag.Title = "Play with the title of the Inventory";
            
            ViewBag.ListOfVehicle = _vehiclestoreturn;
            return View();
        }


        [HttpPost]
        [ActionName("RemoveList")]
        public JsonResult PostRemoveList(Vehicle jsondata)
        {
            //_vehiclestoreturn.Remove(model);
            return Json(JsonConvert.SerializeObject(jsondata));
        }

        [HttpPost]
        [ActionName("EditList")]
        public JsonResult PostEditList(Vehicle jsondata)
        {

            //Vehicle model = JsonConvert.DeserializeObject<Vehicle>(jsondata);

            //var vehicleRecovered = _vehiclestoreturn.FirstOrDefault(v => v.Make == model.Make && v.Model == model.Model && v.Year == model.Year);

            //_vehiclestoreturn.Remove(model);

            return Json(JsonConvert.SerializeObject(jsondata));
        }
    }
    
}