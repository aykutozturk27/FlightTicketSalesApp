using FlightTicketSalesApp.Entities.Dtos;

namespace FlightTicketSalesApp.Business.Abstract
{
    public interface IFlightService
    {
        /// <summary>
        /// Search result with flightRequestDto
        /// </summary>
        /// <param name="flightRequestDto"></param>
        /// <returns></returns>
        List<FlightResultDto> GetAllByRequest(FlightRequestDto flightRequestDto);
    }
}
