using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.RoomDto
{
    public class CreateRoomDto
    {
        [Required(ErrorMessage = "Lütfen oda numarası giriniz.")]
        [StringLength(5,ErrorMessage = "Oda numarası 5 karakterden büyük olamaz.")]
        public string? RoomNumber { get; set; }
        [Required(ErrorMessage = "Oda görseli boş bırakılamaz.")]
        public string? RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Fiyat bilgisi boş geçilemez")]
        [MaxLength(10,ErrorMessage = "Lütfen 10 karakter sınırını geçmeyin")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı giriniz.")]
        [StringLength(120,ErrorMessage = "Lütfen 120 karakter sınırını geçmeyin")]
        public string? Title { get; set; }
        [StringLength(10, ErrorMessage = "Lütfen 10 karakter sınırını geçmeyin")]
        public string? BedCount { get; set; }
        [StringLength(10, ErrorMessage = "Lütfen 10 karakter sınırını geçmeyin")]
        public string? BathCount { get; set; }
        [Required(ErrorMessage = "Wifi durumunu yazınız.")]
        [StringLength(10, ErrorMessage = "Lütfen 10 karakter sınırını geçmeyin")]
        public string? Wifi { get; set; }
        [StringLength(500, ErrorMessage = "Lütfen 500 karakter sınırını geçmeyin")]
        public string? Description { get; set; }
    }
}
