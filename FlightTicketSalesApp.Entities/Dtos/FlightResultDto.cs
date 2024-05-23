using FlightTicketSalesApp.Core.Entities;

namespace FlightTicketSalesApp.Entities.Dtos
{
    public class FlightResultDto : IDto
    {
        public DateTime DepartureDateTime { get; set; }//gidiş tarihi
        public DateTime ArrivalDateTime { get; set; }//dönüş tarihi
        public string? FlightNumber { get; set; }
        public decimal Price { get; set; }
    }
}
