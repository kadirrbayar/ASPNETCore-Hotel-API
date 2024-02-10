using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        [Required(ErrorMessage = "Id bilgisi boş geçilemez.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık alanı gereklidir.")]
        [StringLength(20, ErrorMessage = "Başlık alanı 20 karakterden büyük olamaz.")]
        public string? Title1 { get; set; }

        [Required(ErrorMessage = "Başlık alanı gereklidir.")]
        [StringLength(20, ErrorMessage = "Başlık alanı 20 karakterden büyük olamaz.")]
        public string? Title2 { get; set; }

        [Required(ErrorMessage = "Açıklama alanı gereklidir.")]
        [StringLength(550, ErrorMessage = "Açıklama alanı 100 karakterden büyük olamaz.")]
        public string? Description { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
