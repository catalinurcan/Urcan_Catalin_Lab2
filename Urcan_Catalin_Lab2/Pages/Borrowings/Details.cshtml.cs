using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urcan_Catalin_Lab2.Data;
using Urcan_Catalin_Lab2.Models;

namespace Urcan_Catalin_Lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Urcan_Catalin_Lab2.Data.Urcan_Catalin_Lab2Context _context;

        public DetailsModel(Urcan_Catalin_Lab2.Data.Urcan_Catalin_Lab2Context context)
        {
            _context = context;
        }

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
            //    var bookList = _context.Book
            //.Include(b => b.Author)
            //.Select(x => new
            //{
            //    x.ID,
            //    BookFullName = x.Title + " - " + x.Author.LastName + " " + x.Author.FirstName
            //});

            //    ViewData["BookID"] = new SelectList(bookList, "ID", "BookFullName");
            //    ViewData["MemberID"] = new SelectList(_context.Member, "ID", "FullName");
            }

            
            return Page();
        }
    }
}
