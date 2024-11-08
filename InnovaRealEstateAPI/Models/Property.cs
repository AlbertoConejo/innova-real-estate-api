using System.ComponentModel.DataAnnotations;

namespace InnovaRealEstateAPI.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required]
        public string? Image { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        public string? TourLink { get; set; }
    }
}
