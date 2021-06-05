using Microsoft.AspNetCore.Mvc;
using shoooooop.Data.models;
using shoooooop.Data.Repository;
using shoooooop.Interfaces;
using shoooooop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Controlers
{
   /* public class ShopCartController : Controller
    {
        private readonly iAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(iAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");

        }

    }*/
}
