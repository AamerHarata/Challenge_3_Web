using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Challenge_3_Web.Data;
using Microsoft.AspNetCore.Mvc;
using Challenge_3_Web.Models;

namespace Challenge_3_Web.Controllers
{
    public class ActivityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActivityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataStream()
        {
            var allData = _context.RowData.OrderByDescending(x => x.TimeStamp).ThenBy(x => x.GroupNumber).ToList();
            
            return View(allData);
        }

        public IActionResult DeleteData(string groupNumber)
        {
            _context.RemoveRange(_context.RowData.ToList());
            _context.SaveChanges();
            return RedirectToAction(nameof(DataStream));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
