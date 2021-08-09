using System.ComponentModel.DataAnnotations;

namespace LoginAndRegistration.Models
{
    public class Login
    {
        [Required]
        [MinLength(4)]
        public string Email { get; set; }

        [Required]
        [MinLength(4)]
        public string Password { get; set; }  
    }
}