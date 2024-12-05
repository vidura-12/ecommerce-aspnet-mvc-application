using eTickets.Data.@enum;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public double price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCatogory MovieCatogory { get; set; }
        public string Name { get; set; }
        public string PosterUrl { get; set; }
        public string Description { get; set; }
    }
}
