using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Colta_Iulia_Lab8.Data;
using Colta_Iulia_Lab8.Models;

namespace Colta_Iulia_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Colta_Iulia_Lab8.Data.Colta_Iulia_Lab8Context _context;

        public IndexModel(Colta_Iulia_Lab8.Data.Colta_Iulia_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
