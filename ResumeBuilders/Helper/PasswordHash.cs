using Microsoft.AspNetCore.Identity;
using ResumeBuilders.Models.Entities;

namespace ResumeBuilders.Helper
{
    public class PasswordHash
    {
        private static readonly PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
        public static string HashPassword(User user, string password)
        {
            return _passwordHasher.HashPassword(user, password);
        }
        public static bool VerifyPassword(User user,string hashedPassword,string inputPassword)
        {
            var result=_passwordHasher.VerifyHashedPassword(
                user,
                hashedPassword,
                inputPassword
            );
            return result == PasswordVerificationResult.Success;
        }
    }
}

