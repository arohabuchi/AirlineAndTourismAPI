using AirlineAndTourismAPI.Dto.Flight;
using AirlineAndTourismAPI.Models;

namespace AirlineAndTourismAPI.Data.Interface
{
    public interface IFlightRepo
    {
        Task<List<Flight>> GetAllAsync();
        Task<Flight?> GetByIdAsync(int id);
        Task<Flight> CreateAsync(Flight flightModel);
        Task<Flight?> updateAsync(int id, updateFlightRequestDto updateFlightRequestDto);
        Task<Flight?> DeleteAsync(int id);
    }
}
