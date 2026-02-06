using Microsoft.EntityFrameworkCore;
using ResumeBuilders.Models.Entities;

namespace ResumeBuilders.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Resume> Resumes { get; set; }


    }
}
