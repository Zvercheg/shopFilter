using shoooooop.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Interfaces
{
    public interface iAllCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> getFavCars { get;  }
        Car getObjectCar(int carid);
    }
}
