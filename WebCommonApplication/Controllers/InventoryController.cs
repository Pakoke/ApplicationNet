using Inventory.Dtos;
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
    
    public class InventoryController : Controller
    {
        
        
        List<Vehicle> _vehiclestoreturn = new List<Vehicle>();

        
        // GET: Inventory
        public ActionResult Index()
        {

            ViewBag.Title = "Play with the title of the Inventory";
            _vehiclestoreturn = new List<Vehicle>()
            {
                new Vehicle() {
                    Year = 1926,Make="Chrysler",Model="Imperial"
                },
                new Vehicle() {
                    Year = 1948,Make="Citroën",Model="2CV"
                },
                new Vehicle() {
                    Year = 1950,Make="Hillman",Model="Minx Magnificent"
                }
            };
            
            ViewBag.ListOfVehicle = _vehiclestoreturn;
            return View();
        }


        [HttpPost]
        public JsonResult RemoveFromTheList(Vehicle model)
        {
            _vehiclestoreturn.Remove(model);
            return Json(model, "json");
        }
    }
    
}