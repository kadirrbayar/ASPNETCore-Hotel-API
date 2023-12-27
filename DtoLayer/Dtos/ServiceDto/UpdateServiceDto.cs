using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        [Required(ErrorMessage = "Id bilgisi boş geçilemez.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen ikon bilgisi girin.")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Icon { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet başlığı giriniz")]
        [StringLength(120, ErrorMessage = "120 karakterden büyük olmamalıdır.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş geçilemez.")]
        [StringLength(500, ErrorMessage = "500 karakterden büyük olmamalıdır.")]
        public string? Description { get; set; }
    }
}
