using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Utility;

namespace RestaurantManagementSystem.Pages.Restaurants
{
    [Authorize(Policy =SD.AdminEndUser)]
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Restaurant Restaurants { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Restaurants.Add(Restaurants);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}