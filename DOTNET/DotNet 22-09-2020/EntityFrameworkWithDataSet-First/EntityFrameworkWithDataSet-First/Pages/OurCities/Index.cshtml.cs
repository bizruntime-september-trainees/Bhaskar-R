using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkWithDataSet_First.Models;

namespace EntityFrameworkWithDataSet_First.Pages.OurCities
{
    public class IndexModel : PageModel
    {
        private readonly EntityFrameworkWithDataSet_First.Models.TestDBContext _context;

        public IndexModel(EntityFrameworkWithDataSet_First.Models.TestDBContext context)
        {
            _context = context;
        }

        public IList<Cities> Cities { get;set; }

        public async Task OnGetAsync()
        {
            Cities = await _context.Cities
                .Include(c => c.Country).ToListAsync();
        }
    }
}
