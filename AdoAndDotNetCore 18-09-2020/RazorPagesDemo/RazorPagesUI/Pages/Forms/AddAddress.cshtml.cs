using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUI.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]
        public AddressModel1  Address { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("/Index",new { Name = Address.Name });
        }
    }
}
