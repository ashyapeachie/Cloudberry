using Cloudberry.Data;
using Cloudberry.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cloudberry.Controllers
{
    public class MoodController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoodController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var moods = _context.MoodEntries
                .OrderByDescending(m => m.DateCreated)
                .ToList();

            return View(moods);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MoodEntry moodEntry)
        {
            if (ModelState.IsValid)
            {
                _context.MoodEntries.Add(moodEntry);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(moodEntry);
        }
    }
}
