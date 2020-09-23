﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkWithDataSet_First.Models;

namespace EntityFrameworkWithDataSet_First.Pages.OurCities
{
    public class DeleteModel : PageModel
    {
        private readonly EntityFrameworkWithDataSet_First.Models.TestDBContext _context;

        public DeleteModel(EntityFrameworkWithDataSet_First.Models.TestDBContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cities = await _context.Cities.FindAsync(id);

            if (Cities != null)
            {
                _context.Cities.Remove(Cities);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
