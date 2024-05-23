using AutoMapper;
using FlightTicketSalesApp.Entities.Concrete;
using FlightTicketSalesApp.Entities.Dtos;

namespace FlightTicketSalesApp.Business.Mappings.AutoMapper.Profiles
{
    public class AirlineProfile : Profile
    {
        public AirlineProfile()
        {
            CreateMap<List<Airline>, AirlineListDto>()
                .ForMember(x => x.Airlines, y => y.MapFrom(z => z.ToList()))
                .ReverseMap();
        }
    }
}
