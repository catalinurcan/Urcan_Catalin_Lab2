using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Urcan_Catalin_Lab2.Data;
using Urcan_Catalin_Lab2.Models;

namespace Urcan_Catalin_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Urcan_Catalin_Lab2.Data.Urcan_Catalin_Lab2Context _context;

        public DetailsModel(Urcan_Catalin_Lab2.Data.Urcan_Catalin_Lab2Context context)
        {
            _context = context;
        }

        public Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else
            {
                Author = author;
            }
            return Page();
        }
    }
}
