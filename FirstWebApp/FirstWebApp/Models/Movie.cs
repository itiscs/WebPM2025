using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebApp.Models
{
    public class Movie
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите название")]
        [DisplayName("Название")]
        [StringLength(150)]
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(50)]
       // [Compare("Title")]
        public string? Genre { get; set; }

        [Range(0,1000)]
        
        public decimal? Price { get; set; }

        [NotMapped]
        public int MyProperty { get; set; }
    }
}

