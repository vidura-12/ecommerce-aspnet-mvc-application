namespace eTickets.Models
{
    public class Actor_Movies
    {
        public int MovieId { get; set; }
        public int actorId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
