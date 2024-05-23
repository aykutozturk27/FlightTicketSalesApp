using FlightTicketSalesApp.Business.Constants;
using FlightTicketSalesApp.Entities.Dtos;
using FluentValidation;

namespace FlightTicketSalesApp.Business.ValidationRules.FluentValidation
{
    public class FlightValidator : AbstractValidator<FlightRequestDto>
    {
        public FlightValidator()
        {
            RuleFor(x => x.Destination).NotEmpty().WithMessage(Messages.DestinationIsNotEmpty);
            RuleFor(x => x.Origin).NotEmpty().WithMessage(Messages.OriginIsNotEmpty);
            RuleFor(x => x.DepartureDate).NotEmpty().WithMessage(Messages.DepartureDateIsNotEmpty);
        }
    }
}
