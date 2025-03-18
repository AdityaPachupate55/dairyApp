using Microsoft.AspNetCore.Mvc;
using MyDairyApp.Data;

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
            return View();
        }
    }
}
