using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.ContactDto
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Message { get; set; }
        public string? Subject { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryId { get; set; }
    }
}
