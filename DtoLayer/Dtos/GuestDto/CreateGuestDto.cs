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
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? City { get; set; }
    }
}
