using System.ComponentModel.DataAnnotations;

namespace DGCAdmin.API.DTOs
{
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}