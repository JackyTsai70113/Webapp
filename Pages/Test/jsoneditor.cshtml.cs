using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webapp.Pages.Test
{
    public class jsoneditorModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
