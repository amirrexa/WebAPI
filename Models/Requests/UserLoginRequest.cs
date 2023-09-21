using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.Requests
{
    public class UserLoginRequest
    {
        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}