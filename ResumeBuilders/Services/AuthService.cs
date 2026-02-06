using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeBuilders.Data;
using ResumeBuilders.Models.ViewModels;
using ResumeBuilders.Models.Entities;
using ResumeBuilders.Helper;

namespace ResumeBuilders.Services
{
    public class AuthService
    {
        private readonly ApplicationDbContext _context;
        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<(bool IsSuccess,string Message)>SignupAsync(SignupViewModel model)
        {
            bool emailExists = await _context.Users.AnyAsync(u => u.Email == model.Email);

            if (emailExists)
            {
                return (false, " Email already exists");
            }
            var user = new User
            {
                Name = model.Name,
                Email = model.Email,
                CreatedAt = DateTime.UtcNow
            };
            user.PasswordHash = PasswordHash.HashPassword(user, model.Password);

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return (true, "Registration Successful");
        }
        public async Task<(bool IsSuccess,User ? User,string Message)> LoginAsync(LoginViewModel model)
        {
            var user = await _context.Users
                     .FirstOrDefaultAsync(u => u.Email == model.Email);
            if(user==null)
            {
                return (false, null, "Invalid email or password");
            }
            bool isPasswordValid = PasswordHash.VerifyPassword(user,
                        user.PasswordHash,
                        model.Password);
            if(!isPasswordValid)
            {
                return (false, null, "invalid email or password");
            }
            return (true, user, "login successful");
        }
    }
}
