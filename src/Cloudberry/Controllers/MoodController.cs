using Microsoft.AspNetCore.Mvc;

namespace Cloudberrt_test.Controllers
{
    public class MoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
