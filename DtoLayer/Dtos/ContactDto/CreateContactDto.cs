using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.ContactDto
{
    public class CreateContactDto
    {
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Message { get; set; }
        public string? Subject { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryId { get; set; }
    }
}
