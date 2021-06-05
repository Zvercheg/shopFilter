using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Data.models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Car car { get; set; }
        public int price { get; set; }

        public string ShopCartId {get; set;}
    }
}
