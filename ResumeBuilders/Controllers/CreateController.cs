using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilders.Controllers
{
    public class CreateController : Controller
    {
        public IActionResult Step1()
        {
            ViewBag.Step = 1;
            return View();
        }
        public IActionResult Step2()
        {
            ViewBag.Step = 2;
            return View();
        }
        public IActionResult Step3()
        {
            ViewBag.Step = 3;
            return View();
        }



        public IActionResult Step4()
        {
            ViewBag.Step = 4;
            return View();
        }
        public IActionResult Step5()
        {
            ViewBag.Step = 5;
            return View();
        }
        public IActionResult Step6()
        {
            ViewBag.Step = 6;
            return View();
        }
    }
}
