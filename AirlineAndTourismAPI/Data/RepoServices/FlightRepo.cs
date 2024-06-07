using AirlineAndTourismAPI.Data.Interface;
using AirlineAndTourismAPI.Dto.Flight;
using AirlineAndTourismAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace AirlineAndTourismAPI.Data.RepoServices
{
    public class FlightRepo : IFlightRepo
    {
        private readonly AppDbContext _appDbContext;
        public FlightRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            
        }

        public async Task<Flight> CreateAsync(Flight flightModel)
        {
            await _appDbContext.Flights.AddAsync(flightModel);  
            await _appDbContext.SaveChangesAsync();
            return flightModel;
        }

        public async Task<Flight?> DeleteAsync(int id)
        {
            var flightModel = await _appDbContext.Flights.FirstOrDefaultAsync(x=>x.Id==id);
            if (flightModel==null)
            {
                return null;
            }
             _appDbContext.Flights.Remove(flightModel);
            await _appDbContext.SaveChangesAsync();
            return flightModel;
        }

        public async Task<List<Flight>> GetAllAsync()
        {
            return await _appDbContext.Flights.ToListAsync();
        }

        public async Task<Flight?> GetByIdAsync(int id)
        {
            return await _appDbContext.Flights.FindAsync(id);
        }

        public async Task<Flight?> updateAsync(int id, updateFlightRequestDto updateFlightRequestDto)
        {
            var existingFlight = await _appDbContext.Flights.FirstOrDefaultAsync(x=>x.Id==id);
            if (existingFlight==null) { return null; }
            existingFlight.Name = updateFlightRequestDto.Name;
            existingFlight.Description= updateFlightRequestDto.Description;
            existingFlight.SeatNumber= updateFlightRequestDto.SeatNumber;
            existingFlight.AcquiredDate= updateFlightRequestDto.AcquiredDate;
            await _appDbContext.SaveChangesAsync();
            return existingFlight;
        }
    }
}
