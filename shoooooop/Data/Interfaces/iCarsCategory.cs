using shoooooop.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Interfaces
{
     public interface iCarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
