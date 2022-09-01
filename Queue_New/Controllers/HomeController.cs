using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Queue_New.Data;
using Queue_New.Models;

namespace Queue_New.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.gasColumns.ToListAsync());
        }


        public IActionResult SingUp(int? id)
        {
            var gas = _context.gasColumns.SingleOrDefault(s => s.Id == id);

            if (gas.Occupied == true) gas.Occupied = false;
            else gas.Occupied = true;
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}

