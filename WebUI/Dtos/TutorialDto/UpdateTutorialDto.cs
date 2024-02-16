using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.TutorialDto
{
    public class UpdateTutorialDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? IFrame { get; set; }
    }
}
