using System.ComponentModel.DataAnnotations;

namespace ResumeBuilders.Models.ViewModels
{
    public class SignupViewModel
    {
        [Required(ErrorMessage="name is required")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Invalid email format")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage ="Password is required")]
        [MinLength(6,ErrorMessage ="Password must be atleast 6 characters")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
