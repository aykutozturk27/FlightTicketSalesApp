using FlightTicketSalesApp.Core.Entities;
using FlightTicketSalesApp.Entities.Concrete;

namespace FlightTicketSalesApp.Entities.Dtos
{
    public class AirlineListDto : IDto
    {
        public List<Airline> Airlines { get; set; }
    }
}
