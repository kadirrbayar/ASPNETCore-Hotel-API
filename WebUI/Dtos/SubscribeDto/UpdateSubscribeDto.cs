using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.SubscribeDto
{
    public class UpdateSubscribeDto
    {
        public int Id { get; set; }
        public string? Mail { get; set; }
    }
}
