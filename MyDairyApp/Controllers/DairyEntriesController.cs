using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
                obj.Created = DateTime.Now;
                _context.DairyEntries.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            DairyEntry dairyEntry = _context.DairyEntries.Find(id);
            if (dairyEntry == null) return NotFound();
            return View(dairyEntry);
        }

        [HttpPost]
        public IActionResult Edit(DairyEntry obj)
        {
            if (ModelState.IsValid)
            {
                _context.DairyEntries.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            DairyEntry dairyEntry = _context.DairyEntries.Find(id);

            if (dairyEntry == null) return NotFound();
            return View(dairyEntry);
        }
        

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            if (id == null || id == 0) return NotFound();

            DairyEntry dairyEntry = _context.DairyEntries.Find(id);

            if (dairyEntry == null) return NotFound();

            _context.DairyEntries.Remove(dairyEntry);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
