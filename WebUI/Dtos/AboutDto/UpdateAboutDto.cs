using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        [Required(ErrorMessage = "Id bilgisi boş geçilemez.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Başlık bilgisi boş geçilemez.")]
        [StringLength(20, ErrorMessage = "Başlık alanı 20 karakterden büyük olamaz.")]
        public string? Title1 { get; set; }
        [Required(ErrorMessage = "Başlık bilgisi boş geçilemez.")]
        [StringLength(20, ErrorMessage = "Başlık alanı 20 karakterden büyük olamaz.")]
        public string? Title2 { get; set; }
        [Required(ErrorMessage = "Açıklama bilgisi boş geçilemez.")]
        [StringLength(550, ErrorMessage = "Açıklama alanı 100 karakterden büyük olamaz.")]
        public string? Description { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
