using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantManagementSystem.Data;

namespace RestaurantManagementSystem.ViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<MenuItem> MenuItems { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
