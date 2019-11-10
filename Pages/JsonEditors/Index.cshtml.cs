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
    public class IndexModel : PageModel
    {
        private readonly WebappContext _context;

        public IndexModel(WebappContext context)
        {
            _context = context;
        }

        public IList<JsonEditor> JsonEditor { get; set; }

        public async Task OnGetAsync()
        {
            JsonEditor = await _context.JsonEditor.ToListAsync();
        }
    }
}