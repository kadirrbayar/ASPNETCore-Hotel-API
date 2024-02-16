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
        public int Id { get; set; }
        public string? Mail { get; set; }
    }
}
