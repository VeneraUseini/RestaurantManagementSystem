using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantManagementSystem.Data;

namespace RestaurantManagementSystem.ViewModel
{
    public class MenuItemViewModel
    {
        public MenuItem MenuItem { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public IEnumerable<FoodType> FoodType { get; set; }
    }
}
