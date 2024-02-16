using Microsoft.AspNetCore.Identity;

namespace WebUI.Dtos.DbUserDto
{
    public class DbUserDto:IdentityUser<int>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
    }
}
