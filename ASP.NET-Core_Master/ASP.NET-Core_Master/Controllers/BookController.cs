using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Master.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Master.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {            
            return Json(new { data=await _db.Book.ToListAsync()});
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var BookDb= await _db.Book.FirstOrDefaultAsync(x => x.Id == id);
            if (BookDb==null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            else
            {
                _db.Remove(BookDb);
                await _db.SaveChangesAsync();
                return Json(new { success = true, message = "Delete success" });
            }
        }
    }
}
