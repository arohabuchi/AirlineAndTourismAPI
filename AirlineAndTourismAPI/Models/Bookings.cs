namespace AirlineAndTourismAPI.Models
{
    public class Bookings
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; } = 1;
        public string BookingNumber { get; set; }=string.Empty;
        public ActiveFlight  flight { get; set; }
        public ApplicationUser  AppUser { get; set; }
    }
}
