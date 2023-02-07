using System.ComponentModel.DataAnnotations;

namespace API.Authorization.Models.Users
{
    public class AuthRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
