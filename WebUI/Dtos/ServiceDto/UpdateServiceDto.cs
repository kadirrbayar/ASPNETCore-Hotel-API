using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int Id { get; set; }
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
