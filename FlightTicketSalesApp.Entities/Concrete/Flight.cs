using FlightTicketSalesApp.Core.Entities;

namespace FlightTicketSalesApp.Entities.Concrete
{
    public class Flight : BaseEntity
    {
        public string? Destination { get; set; }//gidiş havalimanı
        public string? Origin { get; set; }//dönüş havalimanı
        public DateTime DepartureDateTime { get; set; }//gidiş tarihi
        public DateTime ArrivalDateTime { get; set; }//dönüş tarihi
        public string? FlightNumber { get; set; }
        public decimal Price { get; set; }
    }
}
