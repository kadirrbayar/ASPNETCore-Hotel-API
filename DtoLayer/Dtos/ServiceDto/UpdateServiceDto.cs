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
        public int Id { get; set; }
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
