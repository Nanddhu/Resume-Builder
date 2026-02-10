using Microsoft.EntityFrameworkCore;
using ResumeBuilders.Models.Entities;
using ResumeBuilders.Models.Entities.Stepper;

namespace ResumeBuilders.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Resume> Resumes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resume>().ToTable("Resumes");
            base.OnModelCreating(modelBuilder);
        }


    }
}
