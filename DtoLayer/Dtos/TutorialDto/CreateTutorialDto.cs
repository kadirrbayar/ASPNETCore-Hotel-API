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
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? IFrame { get; set; }
    }
}
