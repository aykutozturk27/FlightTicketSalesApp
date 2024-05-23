using FlightTicketSalesApp.Core.DataAccess;
using FlightTicketSalesApp.Entities.Concrete;

namespace FlightTicketSalesApp.DataAccess.Abstract
{
    public interface IFlightDal : IEntityRepository<Flight>
    {
    }
}
