using System.ComponentModel.DataAnnotations;

namespace AirlineAndTourismAPI.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }= string.Empty;
        public DateTime AcquiredDate { get; set; }= DateTime.Now;
        //public DateTime NextFlightDate { get; set;}= DateTime.Now;
        //public string NextDestinationAddress { get; set; }=string.Empty;
        //public string currentLocation { get; set; }
        //public double TicketPrice { get; set; }
        public int SeatNumber { get; set; } 
        //public string FlightNumber { get; set; }

    }
}
