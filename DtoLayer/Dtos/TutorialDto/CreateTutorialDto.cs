using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.TutorialDto
{
    public class CreateTutorialDto
    {
        [Required(ErrorMessage = "Başlık alanı boş geçilemez.")]
        [StringLength(50, ErrorMessage = "50 karakterden büyük olmamalıdır.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş geçilemez.")]
        [StringLength(300, ErrorMessage = "300 karakterden büyük olmamalıdır.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Başlık alanı boş geçilemez.")]
        public string? IFrame { get; set; }
    }
}
