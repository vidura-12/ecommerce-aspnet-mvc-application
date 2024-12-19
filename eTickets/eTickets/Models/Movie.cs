using eTickets.Data.@enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        //relationships
        public List<Actor_Movies> Actor_Movies { get; set; }

        //cinema
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        public int CinemaId { get; set; }

        //Producer
        [ForeignKey("Produser_Id")]
        public Produser Produser { get; set; }
        public int ProducerId { get; set; }
    }
}
