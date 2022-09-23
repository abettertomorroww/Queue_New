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

        public IActionResult Index()
        {
            var listOfRecord = _context.gasColumns.ToList();
            return View(listOfRecord);
            //return View(await _context.gasColumns.ToListAsync());
        }
  
        public IActionResult SingUp(int id)
        {
            var gas = _context.gasColumns.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("SingUpPartialView", gas);
        }

        [HttpPost]
        public IActionResult SingUpCodeGenerate(GasColumn gas)
        {
            gas.Code = new Random().Next(1000 - 9999);
            _context.gasColumns.Update(gas);
            _context.SaveChanges();
            return PartialView("CodePartialView", gas);
        }

        public IActionResult SingOut(int id)
        {
            var gas = _context.gasColumns.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("SingOutPartialView", gas);
        }

        [HttpPost]
        public IActionResult SingOutCheckCode(GasColumn gas)
        {
            gas.Code = new Random().Next(1000 - 9999);
            _context.gasColumns.Update(gas);
            _context.SaveChanges();
            return PartialView("CodePartialView", gas);
        }
    }
}


// var gas = _context.gasColumns.SingleOrDefault(s => s.Id == id);

//if (gas.Occupied == false)
//{
//    if (phone != null)
//    {
//        gas.ClienPhoneNumber = phone;
//        gas.Occupied = true;
//    }
//}

//else
//{
//    if (phone == gas.ClienPhoneNumber)
//    {
//        phone = null;
//        gas.Occupied = false;
//    }

//}
//_context.SaveChanges();

//return RedirectToAction("Index");