using FluentValidation;

namespace StarterProject.Api.Features.Positions.Dtos
{
    public class PositionCreateDto
    {
        public string Name { get; set; }
    }

    public class PositionCreateDtoValidator : AbstractValidator<PositionCreateDto>
    {
        public PositionCreateDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}
