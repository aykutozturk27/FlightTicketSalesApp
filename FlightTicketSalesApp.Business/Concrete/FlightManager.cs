using AirSearchWebService;
using FlightTicketSalesApp.Business.Abstract;
using FlightTicketSalesApp.DataAccess.Abstract;
using FlightTicketSalesApp.Entities.Dtos;

namespace FlightTicketSalesApp.Business.Concrete
{
    public class FlightManager : IFlightService
    {
        private readonly IFlightDal _flightDal;
        public FlightManager(IFlightDal flightDal)
        {
            _flightDal = flightDal;
        }

        public List<FlightResultDto> GetAllByRequest(FlightRequestDto flightRequestDto)
        {
            using (var client = new AirSearchClient())
            {
                var searchRequest = new SearchRequest();
                searchRequest.DepartureDate = flightRequestDto.DepartureDate;
                searchRequest.Origin = flightRequestDto.Origin;
                searchRequest.Destination = flightRequestDto.Destination;

                var searchResult = client.AvailabilitySearchAsync(searchRequest).Result;

                var flightResults = new List<FlightResultDto>();
                foreach (var flightOption in searchResult.FlightOptions)
                {
                    var flightResult = new FlightResultDto();
                    flightResult.ArrivalDateTime = flightOption.ArrivalDateTime;
                    flightResult.DepartureDateTime = flightOption.DepartureDateTime;
                    flightResult.FlightNumber = flightOption.FlightNumber;
                    flightResult.Price = flightOption.Price;
                    flightResults.Add(flightResult);
                }

                return flightResults;
            }
        }
    }
}
