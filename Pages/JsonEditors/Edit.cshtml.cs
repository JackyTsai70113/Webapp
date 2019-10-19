using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webapp.Data;
using Webapp.Model;

namespace Webapp.Pages.JsonEditors
{
    public class EditModel : PageModel
    {
        private readonly Webapp.Data.WebappContext _context;

        public EditModel(Webapp.Data.WebappContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(JsonEditor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JsonEditorExists(JsonEditor.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JsonEditorExists(int id)
        {
            return _context.JsonEditor.Any(e => e.Id == id);
        }
    }
}
