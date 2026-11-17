using System.ComponentModel.DataAnnotations;

namespace TryTestDDManh_Day6.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long")]
        public string Name { get; set; } = string.Empty;

        public List<Movie> Movies { get; set; } = new();
    }
}