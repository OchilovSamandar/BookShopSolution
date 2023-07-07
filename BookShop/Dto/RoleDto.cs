using BookShop.Models;

namespace BookShop.Dto
{
    public class RoleDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Permission> Permissions { get; set; }

        public RoleDto(string name, string description, List<Permission> permissions)
        {
            Name = name;
            Description = description;
            Permissions = permissions;
        }
    }
}
