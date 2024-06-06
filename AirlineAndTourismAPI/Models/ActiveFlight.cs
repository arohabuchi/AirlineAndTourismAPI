namespace AirlineAndTourismAPI.Models
{
    public class ActiveFlight
    {
        public int Id { get; set; }
        public DateTime NextFlightDate { get; set; } = DateTime.Now;
        public string NextDestinationAddress { get; set; } = string.Empty;
        public string currentLocation { get; set; } =string.Empty;
        public double TicketPrice { get; set; } =1.00;
        public int MaxSeatNumber { get; set; } = 1;

        //public string FlightNumber { get; set; }=string.Empty;
        public Flight flight { get; set; }

    }
}
