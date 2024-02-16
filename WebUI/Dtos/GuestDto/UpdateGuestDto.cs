using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.GuestDto
{
    public class UpdateGuestDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? City { get; set; }
    }
}
