using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.TestimonialDto
{
    public class UpdateTestimonialDto
    {
        [Required(ErrorMessage = "Id alanı boş geçilemez.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Lütfen referans başlığı giriniz")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama bilgisi giriniz")]
        [StringLength(300, ErrorMessage = "300 karakterden büyük olmamalıdır.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Görsel alanı boş geçilemez.")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Image { get; set; }
    }
}
