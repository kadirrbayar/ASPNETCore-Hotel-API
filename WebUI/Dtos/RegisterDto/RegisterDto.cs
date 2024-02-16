using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.RegisterDto
{
    public class RegisterDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public string? PasswordConfirm { get; set; }
        public string? Username { get; set; }
        public string? Mail { get; set; }
    }
}
