using BookShop.Models;

namespace BookShop.Dto
{
    public class RoleDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<int> PermissionId { get; set; }

        public RoleDto(string name, string description, List<int> permissionId)
        {
            Name = name;
            Description = description;
            PermissionId = permissionId;
        }
    }
}
