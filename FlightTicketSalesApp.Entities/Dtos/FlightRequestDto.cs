using FlightTicketSalesApp.Core.Entities;

namespace FlightTicketSalesApp.Entities.Dtos
{
    public class FlightRequestDto : IDto
    {
        public DateTime DepartureDate { get; set; }//gidiş tarihi
        public DateTime? ArrivalDate { get; set; }//dönüş tarihi
        public string? Destination { get; set; }//gidiş havalimanı
        public string? Origin { get; set; }//dönüş havalimanı
    }
}
