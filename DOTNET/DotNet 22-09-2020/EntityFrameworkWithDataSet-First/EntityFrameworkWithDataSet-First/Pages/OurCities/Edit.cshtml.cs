using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkWithDataSet_First.Models;

namespace EntityFrameworkWithDataSet_First.Pages.OurCities
{
    public class EditModel : PageModel
    {
        private readonly EntityFrameworkWithDataSet_First.Models.TestDBContext _context;

        public EditModel(EntityFrameworkWithDataSet_First.Models.TestDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cities Cities { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cities = await _context.Cities
                .Include(c => c.Country).FirstOrDefaultAsync(m => m.CityId == id);

            if (Cities == null)
            {
                return NotFound();
            }
           ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "CountryId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cities).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitiesExists(Cities.CityId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CitiesExists(string id)
        {
            return _context.Cities.Any(e => e.CityId == id);
        }
    }
}
