using System.ComponentModel.DataAnnotations;

namespace RazaBookingSystem.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public required string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public required string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public required string ConfirmPassword { get; set; }
     }
}
