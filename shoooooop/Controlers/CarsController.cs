using Microsoft.AspNetCore.Mvc;
using shoooooop.Data.models;
using shoooooop.Interfaces;
using shoooooop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using shoooooop.Data;
using PagedList.Mvc;
using PagedList;
using System.Text.RegularExpressions;

namespace shoooooop.Controlers
{

    public class CarsController : Controller
    {

        public int pageSize = 4;


        AppDBContent db;
        public CarsController(AppDBContent context)
        {
            db = context;
        }


        

        public ActionResult List(
            bool categoryElectro,
            bool categoryFuel,
            bool categoryHybro,
            bool categoryDiez,
            string name,
            bool carsyear2019,
            bool carsyear2018,
            bool carsyear2017,
            bool carsyear2016,
            bool carsyear2015,
            bool carsyear2014,
            bool carsyear2013,
            bool carsyear2012,
            bool carsyear2011,
            bool carsyear2010,
            bool rearDrive,
            bool frontDrive,
            bool fullDrive,
            bool sedan,
            bool coupe,
            bool heatchback,
            bool universal,
            bool outroad,
            bool pickup,
            bool mehan,
            bool auto,
            string action,
            int page
            )
        {


//Общая переменная в которую записывается результат
            IQueryable<Car> cars = db.Car.Include(p => p.Category);

//Перемнные для типа кузова
            IQueryable<Car> carsBody = db.Car.Include(p => p.Category);
            IQueryable<Car> carsSedan = db.Car.Include(p => p.Category);
            IQueryable<Car> carsCoupe = db.Car.Include(p => p.Category);
            IQueryable<Car> carsHeatchback = db.Car.Include(p => p.Category);
            IQueryable<Car> carsUniversal = db.Car.Include(p => p.Category);
            IQueryable<Car> carsOutroad = db.Car.Include(p => p.Category);
            IQueryable<Car> carsPickup = db.Car.Include(p => p.Category);

//Переменные для механики || автомата
            IQueryable<Car> KPP = db.Car.Include(p => p.Category);
            IQueryable<Car> carsMehan = db.Car.Include(p => p.Category);
            IQueryable<Car> carsAuto = db.Car.Include(p => p.Category);

//Переменные для типов двигателя (используют переменную cars)
            IQueryable<Car> carsElectro = db.Car.Include(p => p.Category);
            IQueryable<Car> carsFuel = db.Car.Include(p => p.Category);
            IQueryable<Car> carsHybro = db.Car.Include(p => p.Category);
            IQueryable<Car> carsDiez = db.Car.Include(p => p.Category);

//Переменные для типов привода
            IQueryable<Car> carsDrive = db.Car.Include(p => p.Category);
            IQueryable<Car> RearDrive = db.Car.Include(p => p.Category);
            IQueryable<Car> FrontDrive = db.Car.Include(p => p.Category);
            IQueryable<Car> FullDrive = db.Car.Include(p => p.Category);

//Переменные для годов
            IQueryable<Car> carsYear = db.Car.Include(p => p.Category);
            IQueryable<Car> year2019 = db.Car.Include(p => p.Category);
            IQueryable<Car> year2018 = db.Car.Include(p => p.Category);
            IQueryable<Car> year2017 = db.Car.Include(p => p.Category);
            IQueryable<Car> year2016 = db.Car.Include(p => p.Category);
            IQueryable<Car> year2015 = db.Car.Include(p => p.Category);
            IQueryable<Car> year2014 = db.Car.Include(p => p.Category);
            IQueryable<Car> year2013 = db.Car.Include(p => p.Category);
            IQueryable<Car> year2012 = db.Car.Include(p => p.Category);
            IQueryable<Car> year2011 = db.Car.Include(p => p.Category);
            IQueryable<Car> year2010 = db.Car.Include(p => p.Category);
            /*
            int pageSize = 4;
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = cars.ToPagedList(pageNumber, pageSize); // will only contain 4 products max because of the pageSize

            ViewBag.OnePageOfProducts = onePageOfProducts;
            */


            //Проверка чекбоксов в спайке
            if (categoryFuel != false || categoryElectro != false || categoryHybro != false || categoryDiez != false)
            {
//Проверка каждого чек бокса отдельно!
                if (categoryElectro != false)
                {
                    carsElectro = carsElectro.Where(p => p.categoryID == 1);
                    cars = carsElectro;
                }

                if (categoryFuel != false)
                {
                    carsFuel = carsFuel.Where(p => p.categoryID == 2);
                    cars = carsFuel;
                }

                if (categoryHybro != false)
                {
                    carsHybro = carsHybro.Where(p => p.categoryID == 1002);
                    cars = carsHybro;
                }

                if (categoryDiez != false)
                {
                    carsDiez = carsDiez.Where(p => p.categoryID == 1003);
                    cars = carsDiez;
                }


//Проверка ступенками по 2 варианта выборки
                if (categoryFuel != false && categoryElectro != false)
                {
                    cars = carsFuel.Concat(carsElectro);
                }
                if (categoryFuel != false && categoryHybro != false)
                {
                    cars = carsFuel.Concat(carsHybro);
                }
                if (categoryFuel != false && categoryDiez != false)
                {
                    cars = carsFuel.Concat(carsDiez);
                }
                if (categoryElectro != false && categoryHybro != false)
                {
                    cars = carsElectro.Concat(carsHybro);
                }
                if (categoryElectro != false && categoryDiez != false)
                {
                    cars = carsElectro.Concat(carsDiez);
                }
                if (categoryHybro != false && categoryDiez != false)
                {
                    cars = carsHybro.Concat(carsDiez);
                }
//Проверка ступенями по 3 варианта выборки
                if (categoryFuel != false && categoryElectro != false && categoryHybro != false)
                {
                    cars = carsFuel.Concat(carsElectro);
                    cars = cars.Concat(carsHybro);
                }
                if (categoryFuel != false && categoryElectro != false && categoryDiez != false)
                {
                    cars = carsFuel.Concat(carsElectro);
                    cars = cars.Concat(carsDiez);
                }
                if (categoryFuel != false && categoryHybro != false && categoryDiez != false)
                {
                    cars = carsFuel.Concat(carsHybro);
                    cars = cars.Concat(carsDiez);
                }
                if (categoryElectro != false && categoryHybro != false && categoryDiez != false)
                {
                    cars = carsElectro.Concat(carsHybro);
                    cars = cars.Concat(carsDiez);
                }
//Проверка ступенями по 4 варианта выборки
                if (categoryElectro != false && categoryHybro != false && categoryDiez != false && categoryFuel != false)
                {
                    cars = carsElectro.Concat(carsFuel);
                    cars = cars.Concat(carsHybro);
                    cars = cars.Concat(carsDiez);
                }
            }


//Проверка всех чекбоксов годов

            if (
                carsyear2010 != false ||
                carsyear2011 != false ||
                carsyear2012 != false ||
                carsyear2013 != false ||
                carsyear2014 != false ||
                carsyear2015 != false ||
                carsyear2016 != false ||
                carsyear2017 != false ||
                carsyear2018 != false ||
                carsyear2019 != false
                )
            {
//От 19 и ниже 

                if (carsyear2019 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2019));


                    if (carsyear2018 != false)
                    {
                        year2018 = year2018.Where(p => p.year.Equals(2018));
                        carsYear = carsYear.Concat(year2018);
                    }
                    if (carsyear2017 != false)
                    {
                        year2017 = year2017.Where(p => p.year.Equals(2017));
                        carsYear = carsYear.Concat(year2017);
                    }
                    if (carsyear2016 != false)
                    {
                        year2016 = year2016.Where(p => p.year.Equals(2016));
                        carsYear = carsYear.Concat(year2016);
                    }
                    if (carsyear2015 != false)
                    {
                        year2015 = year2015.Where(p => p.year.Equals(2015));
                        carsYear = carsYear.Concat(year2015);
                    }
                    if (carsyear2014 != false)
                    {
                        year2014 = year2014.Where(p => p.year.Equals(2014));
                        carsYear = carsYear.Concat(year2014);
                    }
                    if (carsyear2013 != false)
                    {
                        year2013 = year2013.Where(p => p.year.Equals(2013));
                        carsYear = carsYear.Concat(year2013);
                    }
                    if (carsyear2012 != false)
                    {
                        year2012 = year2012.Where(p => p.year.Equals(2012));
                        carsYear = carsYear.Concat(year2012);
                    }
                    if (carsyear2011 != false)
                    {
                        year2011 = year2011.Where(p => p.year.Equals(2011));
                        carsYear = carsYear.Concat(year2011);
                    }
                    if (carsyear2010 != false)
                    {
                        year2010 = year2010.Where(p => p.year.Equals(2010));
                        carsYear = carsYear.Concat(year2010);
                    }

                }

//Если 19 нет, а 18 да и ниже

                else if (carsyear2018 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2018));

                    if (carsyear2017 != false)
                    {
                        year2017 = year2017.Where(p => p.year.Equals(2017));
                        carsYear = carsYear.Concat(year2017);
                    }
                    if (carsyear2016 != false)
                    {
                        year2016 = year2016.Where(p => p.year.Equals(2016));
                        carsYear = carsYear.Concat(year2016);
                    }
                    if (carsyear2015 != false)
                    {
                        year2015 = year2015.Where(p => p.year.Equals(2015));
                        carsYear = carsYear.Concat(year2015);
                    }
                    if (carsyear2014 != false)
                    {
                        year2014 = year2014.Where(p => p.year.Equals(2014));
                        carsYear = carsYear.Concat(year2014);
                    }
                    if (carsyear2013 != false)
                    {
                        year2013 = year2013.Where(p => p.year.Equals(2013));
                        carsYear = carsYear.Concat(year2013);
                    }
                    if (carsyear2012 != false)
                    {
                        year2012 = year2012.Where(p => p.year.Equals(2012));
                        carsYear = carsYear.Concat(year2012);
                    }
                    if (carsyear2011 != false)
                    {
                        year2011 = year2011.Where(p => p.year.Equals(2011));
                        carsYear = carsYear.Concat(year2011);
                    }
                    if (carsyear2010 != false)
                    {
                        year2010 = year2010.Where(p => p.year.Equals(2010));
                        carsYear = carsYear.Concat(year2010);
                    }
                }
 // 19 и 18 нет 17 да
                else if (carsyear2017 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2017));

                    if (carsyear2016 != false)
                    {
                        year2016 = year2016.Where(p => p.year.Equals(2016));
                        carsYear = carsYear.Concat(year2016);
                    }
                    if (carsyear2015 != false)
                    {
                        year2015 = year2015.Where(p => p.year.Equals(2015));
                        carsYear = carsYear.Concat(year2015);
                    }
                    if (carsyear2014 != false)
                    {
                        year2014 = year2014.Where(p => p.year.Equals(2014));
                        carsYear = carsYear.Concat(year2014);
                    }
                    if (carsyear2013 != false)
                    {
                        year2013 = year2013.Where(p => p.year.Equals(2013));
                        carsYear = carsYear.Concat(year2013);
                    }
                    if (carsyear2012 != false)
                    {
                        year2012 = year2012.Where(p => p.year.Equals(2012));
                        carsYear = carsYear.Concat(year2012);
                    }
                    if (carsyear2011 != false)
                    {
                        year2011 = year2011.Where(p => p.year.Equals(2011));
                        carsYear = carsYear.Concat(year2011);
                    }
                    if (carsyear2010 != false)
                    {
                        year2010 = year2010.Where(p => p.year.Equals(2010));
                        carsYear = carsYear.Concat(year2010);
                    }

                }

// до 16 нет, потом да
                else if (carsyear2016 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2016));


                    if (carsyear2015 != false)
                    {
                        year2015 = year2015.Where(p => p.year.Equals(2015));
                        carsYear = carsYear.Concat(year2015);
                    }
                    if (carsyear2014 != false)
                    {
                        year2014 = year2014.Where(p => p.year.Equals(2014));
                        carsYear = carsYear.Concat(year2014);
                    }
                    if (carsyear2013 != false)
                    {
                        year2013 = year2013.Where(p => p.year.Equals(2013));
                        carsYear = carsYear.Concat(year2013);
                    }
                    if (carsyear2012 != false)
                    {
                        year2012 = year2012.Where(p => p.year.Equals(2012));
                        carsYear = carsYear.Concat(year2012);
                    }
                    if (carsyear2011 != false)
                    {
                        year2011 = year2011.Where(p => p.year.Equals(2011));
                        carsYear = carsYear.Concat(year2011);
                    }
                    if (carsyear2010 != false)
                    {
                        year2010 = year2010.Where(p => p.year.Equals(2010));
                        carsYear = carsYear.Concat(year2010);
                    }

                }
// до 15 нет, потом да
                else if (carsyear2015 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2015));



                    if (carsyear2014 != false)
                    {
                        year2014 = year2014.Where(p => p.year.Equals(2014));
                        carsYear = carsYear.Concat(year2014);
                    }
                    if (carsyear2013 != false)
                    {
                        year2013 = year2013.Where(p => p.year.Equals(2013));
                        carsYear = carsYear.Concat(year2013);
                    }
                    if (carsyear2012 != false)
                    {
                        year2012 = year2012.Where(p => p.year.Equals(2012));
                        carsYear = carsYear.Concat(year2012);
                    }
                    if (carsyear2011 != false)
                    {
                        year2011 = year2011.Where(p => p.year.Equals(2011));
                        carsYear = carsYear.Concat(year2011);
                    }
                    if (carsyear2010 != false)
                    {
                        year2010 = year2010.Where(p => p.year.Equals(2010));
                        carsYear = carsYear.Concat(year2010);
                    }

                }

// до 14 нет, потом да
                else if (carsyear2014 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2014));




                    if (carsyear2013 != false)
                    {
                        year2013 = year2013.Where(p => p.year.Equals(2013));
                        carsYear = carsYear.Concat(year2013);
                    }
                    if (carsyear2012 != false)
                    {
                        year2012 = year2012.Where(p => p.year.Equals(2012));
                        carsYear = carsYear.Concat(year2012);
                    }
                    if (carsyear2011 != false)
                    {
                        year2011 = year2011.Where(p => p.year.Equals(2011));
                        carsYear = carsYear.Concat(year2011);
                    }
                    if (carsyear2010 != false)
                    {
                        year2010 = year2010.Where(p => p.year.Equals(2010));
                        carsYear = carsYear.Concat(year2010);
                    }

                }

// до 13 нет, потом да
                else if (carsyear2013 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2013));

                    if (carsyear2012 != false)
                    {
                        year2012 = year2012.Where(p => p.year.Equals(2012));
                        carsYear = carsYear.Concat(year2012);
                    }
                    if (carsyear2011 != false)
                    {
                        year2011 = year2011.Where(p => p.year.Equals(2011));
                        carsYear = carsYear.Concat(year2011);
                    }
                    if (carsyear2010 != false)
                    {
                        year2010 = year2010.Where(p => p.year.Equals(2010));
                        carsYear = carsYear.Concat(year2010);
                    }

                }

// до 12 нет, потом да
                else if (carsyear2012 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2012));

                    if (carsyear2011 != false)
                    {
                        year2011 = year2011.Where(p => p.year.Equals(2011));
                        carsYear = carsYear.Concat(year2011);
                    }
                    if (carsyear2010 != false)
                    {
                        year2010 = year2010.Where(p => p.year.Equals(2010));
                        carsYear = carsYear.Concat(year2010);
                    }

                }
// до 11 нет, потом да
                else if (carsyear2011 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2011));
                    if (carsyear2010 != false)
                    {
                        year2010 = year2010.Where(p => p.year.Equals(2010));
                        carsYear = carsYear.Concat(year2010);
                    }

                }
// до 10 нет, потом да
                else if (carsyear2010 != false)
                {

                    carsYear = carsYear.Where(p => p.year.Equals(2010));

                }

                }
//Поиск общего у проверки у чекбоксов годов и чекбоксов двигателя

            cars = cars.Intersect(carsYear);

//Проверка чекбоксов по типу привода и реализация моего алгоритма

            if (rearDrive != false || frontDrive != false || fullDrive != false)
            {
                if (rearDrive != false)
                {
                    carsDrive = carsDrive.Where(p => p.driveUnit.Contains("Задний"));
                    

                    if (frontDrive != false)
                    {
                        FrontDrive = FrontDrive.Where(p => p.driveUnit.Contains("Передний"));
                        carsDrive = carsDrive.Concat(FrontDrive);
                    }
                    if (fullDrive != false)
                    {
                        FullDrive = FullDrive.Where(p => p.driveUnit.Contains("Полный"));
                        carsDrive = carsDrive.Concat(FullDrive);
                    }
                }
                else if (frontDrive != false)
                {
                    carsDrive = carsDrive.Where(p => p.driveUnit.Contains("Передний"));
                    
                    if (fullDrive != false)
                    {
                        FullDrive = FrontDrive.Where(p => p.driveUnit.Contains("Полный"));
                        carsDrive = carsDrive.Concat(FullDrive);
                    }
                }
                else if (fullDrive)
                {
                    carsDrive = carsDrive.Where(p => p.driveUnit.Contains("Полный"));
              
                }
            }
//Поиск общего у проверки у чекбоксов типа привода и всего что было ранее

            cars = cars.Intersect(carsDrive);

//Алгоритм для типа кузова 
            
            if(sedan != false || coupe != false || heatchback != false || universal != false || outroad != false || pickup != false)
            {
                if(sedan != false)
                {
                    carsSedan = carsSedan.Where(p => p.bodyType.Contains("Седан"));
                    carsBody = carsSedan;

                    if(coupe != false)
                    {
                        carsCoupe = carsCoupe.Where(p => p.bodyType.Contains("Купе"));
                        carsBody = carsBody.Concat(carsCoupe);
                    }
                    if(heatchback != false)
                    {
                        carsHeatchback = carsHeatchback.Where(p => p.bodyType.Contains("Хетчбек"));
                        carsBody = carsBody.Concat(carsHeatchback);
                    }
                    if(universal != false)
                    {
                        carsUniversal = carsUniversal.Where(p => p.bodyType.Contains("Универсал"));
                        carsBody = carsBody.Concat(carsUniversal);
                    }
                    if (outroad != false)
                    {
                        carsOutroad = carsOutroad.Where(p => p.bodyType.Contains("Внедорожник"));
                        carsBody = carsBody.Concat(carsOutroad);
                    }
                    if (pickup != false)
                    {
                        carsPickup = carsPickup.Where(p => p.bodyType.Contains("Пикап"));
                        carsBody = carsBody.Concat(carsPickup);
                    }
                }
                else if (coupe != false)
                {
                    carsCoupe = carsCoupe.Where(p => p.bodyType.Contains("Купе"));
                    carsBody = carsCoupe;

                    if (heatchback != false)
                    {
                        carsHeatchback = carsHeatchback.Where(p => p.bodyType.Contains("Хетчбек"));
                        carsBody = carsBody.Concat(carsHeatchback);
                    }
                    if (universal != false)
                    {
                        carsUniversal = carsUniversal.Where(p => p.bodyType.Contains("Универсал"));
                        carsBody = carsBody.Concat(carsUniversal);
                    }
                    if (outroad != false)
                    {
                        carsOutroad = carsOutroad.Where(p => p.bodyType.Contains("Внедорожник"));
                        carsBody = carsBody.Concat(carsOutroad);
                    }
                    if (pickup != false)
                    {
                        carsPickup = carsPickup.Where(p => p.bodyType.Contains("Пикап"));
                        carsBody = carsBody.Concat(carsPickup);
                    }
                }
                else if (heatchback != false)
                {
                    carsHeatchback = carsHeatchback.Where(p => p.bodyType.Contains("Хетчбек"));
                    carsBody = carsHeatchback;
                    if (universal != false)
                    {
                        carsUniversal = carsUniversal.Where(p => p.bodyType.Contains("Универсал"));
                        carsBody = carsBody.Concat(carsUniversal);
                    }
                    if (outroad != false)
                    {
                        carsOutroad = carsOutroad.Where(p => p.bodyType.Contains("Внедорожник"));
                        carsBody = carsBody.Concat(carsOutroad);
                    }
                    if (pickup != false)
                    {
                        carsPickup = carsPickup.Where(p => p.bodyType.Contains("Пикап"));
                        carsBody = carsBody.Concat(carsPickup);
                    }
                }
                else if (universal != false)
                {
                    carsUniversal = carsUniversal.Where(p => p.bodyType.Contains("Универсал"));
                    carsBody = carsUniversal;
                    if (outroad != false)
                    {
                        carsOutroad = carsOutroad.Where(p => p.bodyType.Contains("Внедорожник"));
                        carsBody = carsBody.Concat(carsOutroad);
                    }
                    if (pickup != false)
                    {
                        carsPickup = carsPickup.Where(p => p.bodyType.Contains("Пикап"));
                        carsBody = carsBody.Concat(carsPickup);
                    }
                }
                else if (outroad != false)
                {
                    carsOutroad = carsOutroad.Where(p => p.bodyType.Contains("Внедорожник"));
                    carsBody = carsOutroad;
                    if (pickup != false)
                    {
                        carsPickup = carsPickup.Where(p => p.bodyType.Contains("Пикап"));
                        carsBody = carsBody.Concat(carsPickup);
                    }
                }
                else if (pickup != false)
                {
                    carsPickup = carsPickup.Where(p => p.bodyType.Contains("Пикап"));
                    carsBody = carsPickup;
                }
            }

 //Добавление к тому что было ранее типа кузова.

            cars = cars.Intersect(carsBody);

//Алгоритм для Коробки передач

            if(mehan != false || auto != false)
            {
                if (mehan != false)
                {
                    carsMehan = carsMehan.Where(p => p.Transmission.Contains("Механика"));
                    KPP = carsMehan;
                    if (auto != false)
                    {
                        carsAuto = carsAuto.Where(p => p.Transmission.Contains("Автомат"));
                        KPP = KPP.Concat(carsAuto);
                    }
                }
                else if (auto != false)
                {
                    carsAuto = carsAuto.Where(p => p.Transmission.Contains("Автомат"));
                    KPP = carsAuto;
                }
            }
//Добавление к тому что было ранее коробки передач.

            cars = cars.Intersect(KPP);

//Реализация поиска по имени на сайте

            if (!String.IsNullOrEmpty(name))
                {
                     cars = cars.Where(p => p.name.Contains(name));
                }







           
            

            //Создание модели машин которых мы будем "показывать"
            CarsListViewModel viewModel = new CarsListViewModel
            {
                allCars = cars.Skip((page-1)*pageSize).Take(pageSize),

           };


            //string url = HttpContext.Request.QueryString.ToString();
           // var result = Regex.Split(url, "https://localhost:44396/Cars");

            ViewBag.Paging = Set_Paging(page, pageSize, cars.Count(), "activeLink", Url.Action("List", "Cars"), "disableLink");

        //Возврат модели  
            return View(viewModel);
           
        }
        public string Set_Paging(Int32 PageNumber, int PageSize, Int64 TotalRecords, string ClassName, string PageUrl, string DisableClassName)
        {
            string ReturnValue = "";
            try
            {
                Int64 TotalPages = Convert.ToInt64(Math.Ceiling((double)TotalRecords / PageSize));
                if (PageNumber > 1)
                {
                    if (PageNumber == 2)
                        ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim() + "?page=" + Convert.ToString(PageNumber - 1) + "' class='" + ClassName + "'>Previous</a>   ";
                    else
                    {
                        ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim();
                        if (PageUrl.Contains("?"))
                            ReturnValue = ReturnValue + "&";
                        else
                            ReturnValue = ReturnValue + "?";
                        ReturnValue = ReturnValue + "page=" + Convert.ToString(PageNumber - 1) + "' class='" + ClassName + "'>Previous</a>   ";
                    }
                }
                else
                    ReturnValue = ReturnValue + "<span class='" + DisableClassName + "'>Previous</span>   ";
                if ((PageNumber - 3) > 1)
                    ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim() + "' class='" + ClassName + "'>1</a> ..... | ";
                for (int i = PageNumber - 3; i <= PageNumber; i++)
                    if (i >= 1)
                    {
                        if (PageNumber != i)
                        {
                            ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim();
                            if (PageUrl.Contains("?"))
                                ReturnValue = ReturnValue + "&";
                            else
                                ReturnValue = ReturnValue + "?";
                            ReturnValue = ReturnValue + "page=" + i.ToString() + "' class='" + ClassName + "'>" + i.ToString() + "</a> | ";
                        }
                        else
                        {
                            ReturnValue = ReturnValue + "<span style='font-weight:bold;'>" + i + "</span> | ";
                        }
                    }
                for (int i = PageNumber + 1; i <= PageNumber + 3; i++)
                    if (i <= TotalPages)
                    {
                        if (PageNumber != i)
                        {
                            ReturnValue = ReturnValue + "<a href='" + PageUrl.Trim();
                            if (PageUrl.Contains("?"))
                                ReturnValue = ReturnValue + "&";
                            else
                                ReturnValue = ReturnValue + "?";
                            ReturnValue = ReturnValue + "page=" + i.ToString() + "' class='" + ClassName + "'>" + i.ToString() + "</a> | ";
                        }
                        else
                        {
                            ReturnValue = ReturnValue + "<span style='font-weight:bold;'>" + i + "</span> | ";
                        }
                    }
                if ((PageNumber + 3) < TotalPages)
                {
                    ReturnValue = ReturnValue + "..... <a href='" + PageUrl.Trim();
                    if (PageUrl.Contains("?"))
                        ReturnValue = ReturnValue + "&";
                    else
                        ReturnValue = ReturnValue + "?";
                    ReturnValue = ReturnValue + "page=" + TotalPages.ToString() + "' class='" + ClassName + "'>" + TotalPages.ToString() + "</a>";
                }
                if (PageNumber < TotalPages)
                {
                    ReturnValue = ReturnValue + "   <a href='" + PageUrl.Trim();
                    if (PageUrl.Contains("?"))
                        ReturnValue = ReturnValue + "&";
                    else
                        ReturnValue = ReturnValue + "?";
                    ReturnValue = ReturnValue + "page=" + Convert.ToString(PageNumber + 1) + "' class='" + ClassName + "'>Next</a>";
                }
                else
                    ReturnValue = ReturnValue + "   <span class='" + DisableClassName + "'>Next</span>";
            }
            catch (Exception ex)
            {
            }
            return (ReturnValue);
        }

    }
}

