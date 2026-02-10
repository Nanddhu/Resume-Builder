using Microsoft.AspNetCore.Mvc;
using ResumeBuilders.Models.ViewModels;
using ResumeBuilders.Services;

namespace ResumeBuilders.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authServices;
        public AuthController(AuthService authServices)
        {
            _authServices = authServices;
        }
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signup(SignupViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await _authServices.SignupAsync(model);
            if (!result.IsSuccess)
            {
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Login(LoginViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await _authServices.LoginAsync(model);
            if(!result.IsSuccess || result.User == null)
            {
                ModelState.AddModelError("", result.Message);
                return View(model);
            }
            HttpContext.Session.SetInt32("UserID", result.User.UserId);
            HttpContext.Session.SetString("UserName", result.User.Name);
            HttpContext.Session.SetString("UserEmail", result.User.Email);

            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Landing");
        }
    }
}
