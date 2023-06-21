using System.ComponentModel.DataAnnotations;

namespace TravelProject.Models.Clasess
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string PhotoUrl { get; set; }

        public string Description { get; set; }
    }
}