using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Chiriac_Roxana_Lab2.Data;
using Chiriac_Roxana_Lab2.Models;

namespace Chiriac_Roxana_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Chiriac_Roxana_Lab2.Data.BooksDBContext _context;

        public IndexModel(Chiriac_Roxana_Lab2.Data.BooksDBContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
