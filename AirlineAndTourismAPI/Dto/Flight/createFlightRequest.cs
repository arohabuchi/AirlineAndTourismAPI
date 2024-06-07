using System.ComponentModel.DataAnnotations;

namespace AirlineAndTourismAPI.Dto.Flight
{
    public class createFlightRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime AcquiredDate { get; set; } = DateTime.Now;
        public int SeatNumber { get; set; }
    }
}
