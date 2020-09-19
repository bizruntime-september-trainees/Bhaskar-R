using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        //by keeping property in url
        [BindProperty(SupportsGet = true)]
        public String Name { get; set; }
        public void OnGet()
        {
            if(String.IsNullOrWhiteSpace(Name))
            {
                Name = "WebPage";
            }
        }
    }
}
