using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Features.Schedules.Dtos
{
    public class ScheduleEditDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AvailabilityId { get; set; }
        public int? PositionId { get; set; }
    }
    public class ScheduleEditDtoValidator : AbstractValidator<ScheduleEditDto>
    {
        public ScheduleEditDtoValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty();

            RuleFor(x => x.AvailabilityId)
             .NotEmpty();

            RuleFor(x => x.PositionId)
               .NotEmpty();
        }
    }
}
