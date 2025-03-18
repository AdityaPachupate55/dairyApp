using Microsoft.AspNetCore.Mvc;
using MyDairyApp.Data;
using MyDairyApp.Models;

namespace MyDairyApp.Controllers
{
    public class DairyEntriesController : Controller
    {
        private readonly AppDbContext _context;
        public DairyEntriesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<DairyEntry> ObjDairyEntryList = _context.DairyEntries.ToList();
            return View(ObjDairyEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DairyEntry obj)
        {
            if (ModelState.IsValid)
            {
                _context.DairyEntries.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
