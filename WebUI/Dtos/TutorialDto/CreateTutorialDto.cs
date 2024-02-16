using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.TutorialDto
{
    public class CreateTutorialDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? IFrame { get; set; }
    }
}
