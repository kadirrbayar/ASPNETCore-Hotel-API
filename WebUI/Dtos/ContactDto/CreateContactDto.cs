using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.ContactDto
{
    public class CreateContactDto
    {
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Mail alanı boş bırakılamaz.")]
        [StringLength(500, ErrorMessage = "500 karakterden büyük olmamalıdır.")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Mesaj alanı boş bırakılamaz.")]
        [StringLength(500, ErrorMessage = "500 karakterden büyük olmamalıdır.")]
        public string? Message { get; set; }

        [Required(ErrorMessage = "Konu alanı boş bırakılamaz.")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Subject { get; set; }
        public string? Date { get; set; }
    }
}
