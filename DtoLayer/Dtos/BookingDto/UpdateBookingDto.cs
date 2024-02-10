using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.BookingDto
{
    public class UpdateBookingDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Mail alanı boş bırakılamaz.")]
        [StringLength(220, ErrorMessage = "220 karakterden büyük olmamalıdır.")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Giriş Tarihi alanı boş bırakılamaz.")]
        public DateTime CheckIn { get; set; }

        [Required(ErrorMessage = "Çıkış Tarihi alanı boş bırakılamaz.")]
        public DateTime CheckOut { get; set; }

        [Required(ErrorMessage = "Yetişkin sayısı alanı boş bırakılamaz.")]
        public string? AdultCount { get; set; }

        [Required(ErrorMessage = "Çocuk sayısı alanı boş bırakılamaz.")]
        public string? ChildCount { get; set; }

        [Required(ErrorMessage = "Oda sayısı alanı boş bırakılamaz.")]
        public string? RoomCount { get; set; }
        public string? SpecialRequest { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
    }
}
