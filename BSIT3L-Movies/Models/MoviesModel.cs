using System;
namespace BSIT3L_Movies.Models
{
    
	public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public String Cover { get; set; }
        public string Link { get; set; }
        public string Star {  get; set; }
        public string Content { get; set; }

        //https://github.com/ahmedtoba/Movie_Ticket_Reservation/blob/main/MovieTickets/Views/Home/Index.cshtml
        
    }
}

