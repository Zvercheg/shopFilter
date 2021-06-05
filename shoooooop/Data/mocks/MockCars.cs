using shoooooop.Data.models;
using shoooooop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Data.mocks
{
    public class MockCars : iAllCars
    {
        private readonly  iCarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc ="Быстрый автомобиль",
                        longDesc = "Красивый быстрый а главное тихий автомобиль компании Илона",
                        img ="/img/1.jpg",
                        price = 45000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.First()},
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc ="Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img ="/img/2.jpg",
                        price = 15000,
                        isFavorite = false,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                     new Car
                    {
                        name = "BMW M3",
                        shortDesc ="Дерзкий и стильный",
                        longDesc = "Если есть охота понты полимонить - выбор очевиден",
                        img ="/img/3.jpg",
                        price = 35000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                     new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc ="Электрокар для бомжей",
                        longDesc = "Предовращает внеплановую беременность лучше любых контрацептивов, она не забеременеет, если не даст )",
                        img ="/img/4.jpg",
                        price = 65000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                     new Car
                    {
                        name = "Mersedes m class",
                        shortDesc ="уютный и большой",
                        longDesc = "твоя мама точно в него поместиться",
                        img ="/img/5.jpg",
                        price = 63000,
                        isFavorite = false,
                        avaliable = false,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
