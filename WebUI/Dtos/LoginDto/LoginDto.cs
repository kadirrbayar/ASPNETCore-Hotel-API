using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.LoginDto
{
    public class LoginDto
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
