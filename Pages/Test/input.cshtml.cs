using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webapp.Pages.Test
{
    public class inputModel : PageModel
    {
        public inputModel()
        {
        }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
