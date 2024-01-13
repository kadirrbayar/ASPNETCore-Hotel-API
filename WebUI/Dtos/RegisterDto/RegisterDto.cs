using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.RegisterDto
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [StringLength(100, ErrorMessage = "100 karakter sınırını geçmemelidir.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [StringLength(100, ErrorMessage = "100 karakter sınırını geçmemelidir.")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanı zorunludur.")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string? PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur.")]
        [StringLength(120, ErrorMessage = "Lütfen 120 karakter sınırını geçmeyin")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Mail alanı zorunludur.")]
        [StringLength(120, ErrorMessage = "Lütfen 120 karakter sınırını geçmeyin")]
        public string? Mail { get; set; }
    }
}
