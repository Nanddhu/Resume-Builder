using Microsoft.AspNetCore.Mvc;
using ResumeBuilders.Data;
using ResumeBuilders.Models.ViewModels;

namespace ResumeBuilders.Controllers
{
    public class ResumeController : Controller
    {
        public readonly ApplicationDbContext _Context;
        public ResumeController(ApplicationDbContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            var resumes = _Context.Resumes.
                Select(r => new ResumeListViewModel
                {
                    ResumeId = r.ResumeId,
                    Name = r.FullName,
                    CreatedAt = r.CreatedAt,
                    UpdatedAt = r.UpdatedAt,
                    CreatedBy = r.User.Name
                }).ToList();
            return View(resumes);
        }
    }
}
