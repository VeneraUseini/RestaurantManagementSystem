using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Utility;

namespace RestaurantManagementSystem.Pages.MenuItems
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<MenuItem> MenuItem { get; set; }

        public async Task OnGet()
        {
            MenuItem = await _db.MenuItem
                .Include(m=>m.Restaurant)
                .Include(m=>m.FoodType)
                .ToListAsync();
        }
    }
}