using AirlineAndTourismAPI.Dto.Flight;
using AirlineAndTourismAPI.Models;

namespace AirlineAndTourismAPI.Mappers
{
    public static class FlightMapper
    {
        public static FlightDto ToFlightDto(this Flight flightModel)
        {
            return new FlightDto
            {
                Id = flightModel.Id,
                AcquiredDate = flightModel.AcquiredDate,
                Description = flightModel.Description,
                Name = flightModel.Name,
                SeatNumber = flightModel.SeatNumber,
            };
        }
        public static Flight ToFlightFromCreateDto(this createFlightRequest flightDto) 
        {
            return new Flight
            {
                Name = flightDto.Name,
                Description = flightDto.Description,
                SeatNumber = flightDto.SeatNumber,
                AcquiredDate = flightDto.AcquiredDate
            };
        }
    }
}
