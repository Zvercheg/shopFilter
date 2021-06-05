using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shoooooop.Data;
using shoooooop.Data.models;
using shoooooop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace shoooooop.Controlers
{
    public class OpenUpController : Controller
    {
        AppDBContent db;
        public OpenUpController(AppDBContent context)
        {
            db = context;
        }
        
        public ActionResult OpenUp(int carId)
        {
            IQueryable<Car> cars = db.Car.Include(p => p.Category);

            cars = cars.Where(p => p.id.Equals(carId));

            CarsListViewModel viewModel = new CarsListViewModel
            {
                allCars = cars,
            };

            //Возврат модели  
            return View(viewModel);
        }
    }
}
