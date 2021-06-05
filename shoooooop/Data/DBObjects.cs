using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using shoooooop.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
          

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Car.Any())
            {
                content.AddRange
                    (
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый быстрый а главное тихий автомобиль компании Илона",
                        img = "/img/1.jpg",
                        price = 45000,
                        isFavorite = true,
                        avaliable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/2.jpg",
                        price = 15000,
                        isFavorite = false,
                        avaliable = true,
                        Category = Categories["Классические авто"]
                    },
                     new Car
                     {
                         name = "BMW M3",
                         shortDesc = "Дерзкий и стильный",
                         longDesc = "Если есть охота понты полимонить - выбор очевиден",
                         img = "/img/3.jpg",
                         price = 35000,
                         isFavorite = true,
                         avaliable = true,
                         Category = Categories["Классические авто"]
                     },
                     new Car
                     {
                         name = "Nissan Leaf",
                         shortDesc = "Электрокар для бомжей",
                         longDesc = "Предовращает внеплановую беременность лучше любых контрацептивов, она не забеременеет, если не даст )",
                         img = "/img/4.jpg",
                         price = 65000,
                         isFavorite = true,
                         avaliable = true,
                         Category = Categories["Электромобили"]
                     },
                     new Car
                     {
                         name = "Mersedes m class",
                         shortDesc = "уютный и большой",
                         longDesc = "твоя мама точно в него поместиться",
                         img = "/img/5.jpg",
                         price = 63000,
                         isFavorite = false,
                         avaliable = false,
                         Category = Categories["Классические авто"]
                     }
                    );
            }

            content.SaveChanges();
            
        }

            private static Dictionary<string, Category> category;
            public static Dictionary<string,Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Электромобили", desc = "современный вид транспорта"},
                    new Category {categoryName = "Классические авто", desc = "современный вид тавто с двигателем внутреннего сгорания"},
                     new Category {categoryName = "Гибрид", desc = "и электро и бензин"},
                     new Category {categoryName = "Дизель", desc = "дизель"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }

                }
                return category;
            }
        }

    }
    }

