using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Data.models
{
    public class Car
    {
        
        public int id { set; get; } 
        public string name { set; get; }
        public string bodyType { set; get; }
        public int year { set; get; }
        public float engineVolume { set; get; }
        public string Transmission { set; get; }
        public int mileage { set; get; }
        public string damage { set; get; }
        public string driveUnit { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavorite { set; get; }
        public bool avaliable { set; get; }
        public int categoryID { set; get; }

        public  Category Category { set; get; }
    }
}
