using AutoMapper;
using FlightTicketSalesApp.Business.Abstract;
using FlightTicketSalesApp.DataAccess.Abstract;

namespace FlightTicketSalesApp.Business.Concrete
{
    public class AirlineManager : IAirlineService
    {
        private readonly IAirlineDal _airlineDal;
        private readonly IMapper _mapper;

        public AirlineManager(IAirlineDal airlineDal, IMapper mapper)
        {
            _airlineDal = airlineDal;
            _mapper = mapper;
        }

    }
}
