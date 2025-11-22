using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Urcan_Catalin_Lab2.Data;
using Urcan_Catalin_Lab2.Models;

namespace Urcan_Catalin_Lab2.Pages.Borrowings
{
    public class DeleteModel : PageModel
    {
        private readonly Urcan_Catalin_Lab2.Data.Urcan_Catalin_Lab2Context _context;

        public DeleteModel(Urcan_Catalin_Lab2.Data.Urcan_Catalin_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FirstOrDefaultAsync(m => m.ID == id);

            if (borrowing == null)
            {
                return NotFound();
            }
            else
            {
                Borrowing = borrowing;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FindAsync(id);
            if (borrowing != null)
            {
                Borrowing = borrowing;
                _context.Borrowing.Remove(Borrowing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
