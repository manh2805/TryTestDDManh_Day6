using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TryTestDDManh_Day6.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3 , ErrorMessage = "The {0} must be at least {2} and at max {1} characters long")]
        public string Title { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
