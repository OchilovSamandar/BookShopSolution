using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Firstname { get; set; }

        [Required]
        public string? Lastname { get; set; }

        public string Username { get; set; }

        public string Passwrd { get; set; }

        public bool IsEnable { get; set; }

        public Role Role { get; set; }

        public List<Book> Books { get; set; }



    }
}
