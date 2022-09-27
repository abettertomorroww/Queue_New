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

        private Random rnd = new Random();

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listOfRecord = _context.gasColumns.ToList();
            return View(listOfRecord);
        }

        [HttpGet]
        public IActionResult SingUp(int id)
        {
            if (id != 0)
            {
                var gas = _context.gasColumns.Where(x => x.Id == id).FirstOrDefault();
                gas.Code = rnd.Next(1000, 9999);
                return PartialView("SingUpPartialView", gas);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult SingUp(int code, int id, string clienPhoneNumber)
        {
            if (ModelState.IsValid)
            {
                var gas = _context.gasColumns.Where(x => x.Id == id).FirstOrDefault();
                gas.Code = code;
                gas.ClienPhoneNumber = clienPhoneNumber;
                gas.Occupied = true;

                _context.gasColumns.Update(gas);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult SingOut(int id)
        {
            if (id != 0)
            {
                var gas = _context.gasColumns.Where(x => x.Id == id).FirstOrDefault();
                return PartialView("SingOutPartialView", gas);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult SingOut(int id ,int code)
        {
            if (ModelState.IsValid)
            {
                var gas = _context.gasColumns.Where(x => x.Id == id).FirstOrDefault();
                if (gas.Code == code)
                {
                    gas.ClienPhoneNumber = null;
                    gas.Code = 0;
                    gas.Occupied = false;
                    _context.gasColumns.Update(gas);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}


//else
//{
//    var gasColumn = _context.gasColumns.Where(x => x.Code == code).FirstOrDefault();
//    if (gasColumn.Code == code)
//    {
//        gasColumn.ClienPhoneNumber = null;
//        gasColumn.Code = 0;
//        gasColumn.Occupied = false;
//        _context.gasColumns.Update(gasColumn);
//        _context.SaveChanges();
//        return RedirectToAction("Index");
//    }
//}