using Autofac;
using FlightTicketSalesApp.Business.ValidationRules.FluentValidation;
using FlightTicketSalesApp.Entities.Dtos;
using FluentValidation;

namespace FlightTicketSalesApp.Business.DependencyResolvers.Autofac
{
    public class AutofacValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FlightValidator>().As<IValidator<FlightRequestDto>>().SingleInstance();
        }
    }
}
