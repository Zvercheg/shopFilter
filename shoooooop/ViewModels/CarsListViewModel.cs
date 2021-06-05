using Microsoft.AspNetCore.Mvc.Rendering;
using shoooooop.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Mvc.Rendering.SelectList;

namespace shoooooop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }
        public int currCategory { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int PageNumber { get; set; }
      
    }
}
