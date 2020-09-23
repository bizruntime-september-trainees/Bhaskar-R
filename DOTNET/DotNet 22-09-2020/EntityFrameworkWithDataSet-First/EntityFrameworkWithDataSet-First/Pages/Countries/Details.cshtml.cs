using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkWithDataSet_First.Models;

namespace EntityFrameworkWithDataSet_First.Pages.Countries
{
    public class DetailsModel : PageModel
    {
        private readonly EntityFrameworkWithDataSet_First.Models.TestDBContext _context;

        public DetailsModel(EntityFrameworkWithDataSet_First.Models.TestDBContext context)
        {
            _context = context;
        }

        public Country Country { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Country = await _context.Country.FirstOrDefaultAsync(m => m.CountryId == id);

            if (Country == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
