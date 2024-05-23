using Autofac;
using FlightTicketSalesApp.Business.Abstract;
using FlightTicketSalesApp.Business.Concrete;
using FlightTicketSalesApp.DataAccess.Abstract;
using FlightTicketSalesApp.DataAccess.Concrete.EntityFramework;

namespace FlightTicketSalesApp.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfFlightDal>().As<IFlightDal>();
            builder.RegisterType<FlightManager>().As<IFlightService>();

            builder.RegisterType<EfAirlineDal>().As<IAirlineDal>();
            builder.RegisterType<AirlineManager>().As<IAirlineService>();
        }
    }
}
