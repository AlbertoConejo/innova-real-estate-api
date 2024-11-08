using System.ComponentModel.DataAnnotations;

namespace InnovaRealEstateAPI.Models
{
    public class RegisterModel
    {
        [Required]
        public string? Username { get; set; }

        [EmailAddress]
        [Required]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        public string? Role { get; set; } // e.g., "admin" or "user"
    }
}
