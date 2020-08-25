using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Master.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Master.Pages.BookList
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db=db;
        }

        public IEnumerable<Book> Books { get; set; }
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync() ;
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var Book = await _db.Book.FindAsync(id);
            if (Book == null)
            {
                return NotFound();
            }
            else
            {
                _db.Book.Remove(Book);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage("Index");
        }
    }
}