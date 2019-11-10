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
    public class DetailsModel : PageModel
    {
        private readonly Webapp.Data.WebappContext _context;

        public DetailsModel(Webapp.Data.WebappContext context)
        {
            _context = context;
        }

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
    }
}
