using System.ComponentModel.DataAnnotations;

namespace LoginAndRegistration.Models
{
    public class Register
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(4)]
        public string Password { get; set; }

        [Required]
        [MinLength(4)]
        public string ConfirmPassword { get; set; }  
    }
}