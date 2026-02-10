using Microsoft.AspNetCore.Mvc;
using ResumeBuilders.Models.ViewModels;
using ResumeBuilders.Data;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace ResumeBuilders.Controllers
{

    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var userId = HttpContext.Session.GetInt32("UserID");
            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }


            var userName = HttpContext.Session.GetString("UserName");
            var userEmail = HttpContext.Session.GetString("UserEmail");

            ViewBag.UserName = userName;
            ViewBag.UserEmail = userEmail;


            var resumes = _context.Resumes
                .Where(r => r.UserID == userId)
                .Select(r => new ResumeListViewModel
                {
                    ResumeId = r.ID,
                    Name = r.FirstName + " " + r.LastName,
                    CreatedAt = r.CreatedAt,
                    UpdatedAt = r.UpdatedAt,
                    CreatedBy = r.User.Name
                })
                .ToList();


            return View(resumes);
        }
    }
}
