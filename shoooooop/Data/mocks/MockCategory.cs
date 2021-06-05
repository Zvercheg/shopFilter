using shoooooop.Data.models;
using shoooooop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Data.mocks
{
    public class MockCategory : iCarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get{
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "современный вид транспорта"},
                    new Category {categoryName = "Классические авто", desc = "современный вид тавто с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
