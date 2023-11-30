using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(20,MinimumLength =3)]
        [Required]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime ReleaseDate { get; set; }
        [Range(1,100)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Gengre { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }
    }
}
//Part 7, add search to an ASP.NET Core MVC app
