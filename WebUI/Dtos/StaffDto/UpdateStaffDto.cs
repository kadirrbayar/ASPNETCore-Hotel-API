using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.StaffDto
{
    public class UpdateStaffDto
    {
        [Required(ErrorMessage = "Id alanı boş geçilemez.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Başlık alanı boş geçilemez.")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Sosyal medya alanları boş geçilemez.")]
        [StringLength(100, ErrorMessage = "100 karakterden büyük olmamalıdır.")]
        public string? SocialMedia1 { get; set; }

        [Required(ErrorMessage = "Sosyal medya alanları boş geçilemez.")]
        [StringLength(100, ErrorMessage = "100 karakterden büyük olmamalıdır.")]
        public string? SocialMedia2 { get; set; }

        [Required(ErrorMessage = "Sosyal medya alanları boş geçilemez.")]
        [StringLength(100, ErrorMessage = "100 karakterden büyük olmamalıdır.")]
        public string? SocialMedia3 { get; set; }

        [Required(ErrorMessage = "Görsel alanı boş geçilemez.")]
        public string? Image { get; set; }
    }
}
