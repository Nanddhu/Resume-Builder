using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilders.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

