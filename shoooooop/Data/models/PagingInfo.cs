using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Data.models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }  //Общее кол-во машин
        public int ItemsPerPage { get; set;} //Кол-во машин на странице
        public int CurrentPage { get; set; } //Номер текущей страницы
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}
