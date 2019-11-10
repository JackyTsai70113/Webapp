using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Webapp.Data;
using Webapp.Model;

namespace Webapp.Pages.Randomusers
{
    public class DeleteModel : PageModel
    {
        private readonly Webapp.Data.WebappContext _context;

        public DeleteModel(Webapp.Data.WebappContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Randomuser Randomuser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Randomuser = await _context.Randomuser.FirstOrDefaultAsync(m => m.Id == id);

            if (Randomuser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Randomuser = await _context.Randomuser.FindAsync(id);

            if (Randomuser != null)
            {
                _context.Randomuser.Remove(Randomuser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
