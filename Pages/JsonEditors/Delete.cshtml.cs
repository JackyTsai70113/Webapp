using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Webapp.Data;
using Webapp.Model;

namespace Webapp.Pages.JsonEditors
{
    public class DeleteModel : PageModel
    {
        private readonly Webapp.Data.WebappContext _context;

        public DeleteModel(Webapp.Data.WebappContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JsonEditor JsonEditor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JsonEditor = await _context.JsonEditor.FirstOrDefaultAsync(m => m.Id == id);

            if (JsonEditor == null)
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

            JsonEditor = await _context.JsonEditor.FindAsync(id);

            if (JsonEditor != null)
            {
                _context.JsonEditor.Remove(JsonEditor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
