using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace DealerShip.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet ("/cars")]
        public ActionResult Index()
        {
            List<Cars> allCars = Cars.ShowCars();
            return View(allCars);
        }

        [HttpGet ("/cars/new")]
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost("/cars")]
        public ActionResult Create(string makeModel, int price, int miles, string message)
        {
            Cars myCars = new Cars(makeModel,price,miles,message);
            return RedirectToAction("Index");
        }   

        [HttpPost("/cars/delete")]
        public ActionResult DeleteAll()
        {
            Cars.ClearAll();
            return View();
        }
    }
}