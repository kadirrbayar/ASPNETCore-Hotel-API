using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.TestimonialDto
{
    public class UpdateTestimonialDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
