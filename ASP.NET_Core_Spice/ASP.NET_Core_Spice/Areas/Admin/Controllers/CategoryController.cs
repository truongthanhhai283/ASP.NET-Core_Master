using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Spice.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET
        public async Task<IActionResult> Index()
        {
            var data = await _db.Category.ToListAsync();
            return View(data);
        }

        //GET - CREATE
        public IActionResult Create()
        {

            return View();
        }
    }
}
