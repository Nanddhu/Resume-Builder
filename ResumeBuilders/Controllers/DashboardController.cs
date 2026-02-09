using Microsoft.AspNetCore.Mvc;
using ResumeBuilders.Models.ViewModels;
using ResumeBuilders.Data;
using Microsoft.AspNetCore.Http;
using System.Linq;

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
        
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            return RedirectToAction("Login", "Auth");
        }

      
        var userName = HttpContext.Session.GetString("UserName");
        var userEmail = HttpContext.Session.GetString("UserEmail");

        ViewBag.UserName = userName;
        ViewBag.UserEmail = userEmail;

     
        var resumes = _context.Resumes
            .Where(r => r.UserId == userId)
            .Select(r => new ResumeListViewModel
            {
                ResumeId = r.ResumeId,
                Name = r.FullName,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
                CreatedBy = r.User.Name
            })
            .ToList();

        
        return View(resumes);
    }
}
