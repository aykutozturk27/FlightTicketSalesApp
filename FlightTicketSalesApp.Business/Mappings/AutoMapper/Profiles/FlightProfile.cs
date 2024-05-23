using AutoMapper;
using FlightTicketSalesApp.Entities.Concrete;
using FlightTicketSalesApp.Entities.Dtos;

namespace FlightTicketSalesApp.Business.Mappings.AutoMapper.Profiles
{
    public class FlightProfile : Profile
    {
        public FlightProfile()
        {
            CreateMap<Flight, FlightResultDto>().ReverseMap();
        }
    }
}
