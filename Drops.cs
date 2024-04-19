using Cascading.Data;
using Cascading.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Cascading.Controllers
{
    public class DropsController : Controller
    {
        private readonly CascadingDbContext _context;

        public DropsController(CascadingDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Create()
        {
            var countries = await _context.Country.ToListAsync();
            var viewModel = new CountryStateCityViewModel { Countries = countries };
            return View(viewModel);
        }

         

        public async Task<IActionResult> GetStatesByCountryId(int countryId)
        {
            

            var states = await _context.State
                .Where(s => s.CountryID == countryId)
                .ToListAsync();
            return Json(new { states });
        }

        public async Task<IActionResult> GetCitiesByStateId(int stateId)
        {
            
           
            var cities = await _context.City
                .Where(c => c.StateID == stateId)
                .ToListAsync();
            return Json(new { cities });
        }
    }
}
