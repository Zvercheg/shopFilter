using Microsoft.AspNetCore.Mvc;
using shoooooop.Interfaces;
using shoooooop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Controlers
{
    public class HomeController : Controller
    {
        private readonly iAllCars _carRep;
        

        public HomeController(iAllCars carRep)
        {
            _carRep = carRep;
           
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }

    }
}
