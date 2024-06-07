using AirlineAndTourismAPI.Data;
using AirlineAndTourismAPI.Data.Interface;
using AirlineAndTourismAPI.Dto.Flight;
using AirlineAndTourismAPI.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirlineAndTourismAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightRepo _flightRepo;

        public FlightController( IFlightRepo flightRepo)
        {
            _flightRepo = flightRepo;
            
        }
        [HttpGet]
        public async Task<ActionResult> GetAllFlight()
        {
            var flights = await _flightRepo.GetAllAsync();
             var flightDto= flights.Select(f=>f.ToFlightDto()).ToList();
            return Ok(flightDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> FlightDetail([FromRoute] int id)
        {
            var flight = await _flightRepo.GetByIdAsync(id);
            if (flight == null)
            {
                return NotFound();
            }
            return Ok(flight.ToFlightDto());
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] createFlightRequest flightDto)
        {
            var flightmodel = flightDto.ToFlightFromCreateDto();
            await _flightRepo.CreateAsync(flightmodel);
            //await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(FlightDetail), new { id = flightmodel.Id }, flightmodel.ToFlightDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] updateFlightRequestDto updateflightDto)
        {
            var flightmodel =await _flightRepo.updateAsync(id, updateflightDto);
            if (flightmodel == null)
            {
                return NotFound();
            }
            //await _context.SaveChangesAsync();

            return Ok(flightmodel.ToFlightDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var flightmodel = await _flightRepo.DeleteAsync(id);
            if (flightmodel == null)
            {
                return NotFound();
            }

            //await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
