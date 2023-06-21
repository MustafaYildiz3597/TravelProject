using System.ComponentModel.DataAnnotations;

namespace TravelProject.Models.Clasess
{
    public class HomePage
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; } 
    }
}