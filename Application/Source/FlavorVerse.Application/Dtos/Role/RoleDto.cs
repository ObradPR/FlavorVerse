namespace FlavorVerse.Application.Dtos.Role;

public class RoleDto : BaseDto
{
    public IEnumerable<string> Roles { get; set; } = new HashSet<string>();
}