namespace WebUI.Dtos.DbUserDto
{
    public class UpdateDbUserDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Surname { get; set; }
        public string? CurrentPassword { get; set; }
        public string? Password { get; set; }
        public string? PasswordConfirm { get; set; }
        public string? Username { get; set; }
        public string? Mail { get; set; }
    }
}
