using Autofac;
using AutoMapper;

namespace FlightTicketSalesApp.Business.DependencyResolvers.Autofac
{
    public class AutofacAutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(CreateConfiguration().CreateMapper()).As<IMapper>();
        }

        private MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(GetType().Assembly);
            });

            return config;
        }
    }
}
