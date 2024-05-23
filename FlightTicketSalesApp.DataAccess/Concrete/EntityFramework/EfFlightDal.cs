using FlightTicketSalesApp.Core.DataAccess.EntityFramework;
using FlightTicketSalesApp.DataAccess.Abstract;
using FlightTicketSalesApp.DataAccess.Concrete.EntityFramework.Contexts;
using FlightTicketSalesApp.Entities.Concrete;

namespace FlightTicketSalesApp.DataAccess.Concrete.EntityFramework
{
    public class EfFlightDal : EfEntityRepositoryBase<Flight, FlightTicketSalesAppContext>, IFlightDal
    {
    }
}
