using System.Security;

namespace BookShop.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Permission> Permissions { get; set; }


    
    }
}