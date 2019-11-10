using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webapp.Pages.Plugins
{
    public class PopperModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}