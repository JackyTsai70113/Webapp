using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Webapp.Data;
using Webapp.Model;

namespace Webapp.Pages.Randomusers
{
    public class CreateModel : PageModel
    {
        private readonly Webapp.Data.WebappContext _context;

        public CreateModel(Webapp.Data.WebappContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Randomuser Randomuser { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Randomuser.Add(Randomuser);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
