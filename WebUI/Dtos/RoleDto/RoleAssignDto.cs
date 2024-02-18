namespace WebUI.Dtos.RoleDto
{
    public class RoleAssignDto
    {
        public int Id { get; set; }
        public string? RoleName { get; set; }
        public bool Exist { get; set; }
        public int UserId { get; set; }
    }
}
