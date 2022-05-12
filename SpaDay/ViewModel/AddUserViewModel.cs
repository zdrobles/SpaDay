using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="Username must be between 5 and 15 characters long.")]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="Password must be betweeen 6 and 20 characters long.")]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The two properties must match!")]
        public string VerifyPassword { get; set; }
    }
}
