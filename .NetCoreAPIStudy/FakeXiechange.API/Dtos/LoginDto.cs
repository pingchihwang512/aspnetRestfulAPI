using System.ComponentModel.DataAnnotations;

namespace FakeXiechange.API.Dtos
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }    
    }
}
