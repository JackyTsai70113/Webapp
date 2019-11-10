using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Webapp.Data;
using Webapp.Model;

namespace Webapp.Pages.Plugins.DataTable
{
    public class IndexModel : PageModel
    {
        private readonly WebappContext _context;
        public IndexModel(WebappContext context)
        {
            _context = context;
        }

        public IList<Model.Randomuser> randomuser { get; set; }

        // public IActionResult OnGet()
        // {
        //     return Page();
        // }
        public async Task OnGetAsync()
        {
            randomuser = await _context.Randomuser.ToListAsync();
        }
    }
}