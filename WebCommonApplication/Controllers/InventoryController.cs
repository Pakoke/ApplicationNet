using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCommonApplication.Models;

namespace WebCommonApplication.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            ViewBag.Title = "Play with the title of the Inventory";
            var car = new Car();
            return View(car);
        }

        [HttpPost]
        public ActionResult Index(Car car)
        {
            return View(car);
        }

    }
}