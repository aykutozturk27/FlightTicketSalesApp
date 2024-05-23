using FlightTicketSalesApp.Business.Abstract;
using FlightTicketSalesApp.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FlightTicketSalesApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;

        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        //uçuş arama
        [HttpPost("getallbyrequest")]
        public IActionResult GetAllByRequest(FlightRequestDto flightRequestDto)
        {
            var flightList = _flightService.GetAllByRequest(flightRequestDto);
            if (flightList == null)
                return NotFound();
            return Ok(flightList);
        }
    }
}
