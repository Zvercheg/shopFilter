using Microsoft.EntityFrameworkCore;
using shoooooop.Data.models;
using shoooooop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Data.Repository
{
    public class CarRepository : iAllCars
    {

        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavorite).Include(c => c.Category);

        public Car getObjectCar(int carid) => appDBContent.Car.FirstOrDefault(p => p.id == carid);
        
    }
}
