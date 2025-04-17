using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [DisplayName("Название")]        
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}

