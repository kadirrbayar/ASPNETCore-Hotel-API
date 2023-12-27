using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.SubscribeDto
{
    public class UpdateSubscribeDto
    {
        [Required(ErrorMessage = "Id alanı boş geçilemez.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mail alanı boş geçilemez.")]
        [StringLength(300, ErrorMessage = "300 karakterden büyük olmamalıdır.")]
        public string? Mail { get; set; }
    }
}
