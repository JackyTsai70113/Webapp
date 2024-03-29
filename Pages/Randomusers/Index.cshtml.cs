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
    public class IndexModel : PageModel
    {
        private readonly Webapp.Data.WebappContext _context;

        public IndexModel(Webapp.Data.WebappContext context)
        {
            _context = context;
        }

        public IList<Randomuser> Randomuser { get;set; }

        public async Task OnGetAsync()
        {
            Randomuser = await _context.Randomuser.ToListAsync();
        }
    }
}
