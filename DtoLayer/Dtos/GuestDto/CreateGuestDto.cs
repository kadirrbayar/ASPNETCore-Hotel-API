using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.GuestDto
{
    public class CreateGuestDto
    {
        [Required(ErrorMessage = "Lütfen ad bilgisi giriniz.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Ad alanı 100 karakterden büyük ve 2 karakterden küçük olamaz.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyad bilgisi giriniz.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Soyad alanı 100 karakterden büyük ve 2 karakterden küçük olamaz.")]
        public string? SurName { get; set; }

        [Required(ErrorMessage = "Şehir bilgisi boş geçilemez")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Şehir alanı 100 karakterden büyük ve 3 karakterden küçük olamaz.")]
        public string? City { get; set; }
    }
}
