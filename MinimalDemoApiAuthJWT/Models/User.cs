using System.ComponentModel.DataAnnotations;

namespace MinimalDemoApiAuthJWT.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "enter the name")]
        [MaxLength(10, ErrorMessage = "max 10 characters")]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
