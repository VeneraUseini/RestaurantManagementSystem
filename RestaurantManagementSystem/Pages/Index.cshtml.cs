using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.ViewModel;

namespace RestaurantManagementSystem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [TempData]
        public string StatusMessage { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public IndexViewModel IndexVM { get; set; }

        public async Task OnGet()
        {
            IndexVM = new IndexViewModel() {
                MenuItems = await _db.MenuItem.Include(m => m.Restaurant).Include(m => m.FoodType).ToListAsync(),
                Restaurants = _db.Restaurants.OrderBy(c => c.DisplayOrder)
            };
        }
    }
}
