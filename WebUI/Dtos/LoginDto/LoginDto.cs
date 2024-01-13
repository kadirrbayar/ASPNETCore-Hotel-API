using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.LoginDto
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Mail alanı boş geçilemez.")]
        [StringLength(100, ErrorMessage = "120 karakter sınırını geçmemelidir.")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        public string? Password { get; set; }
    }
}
