using FluentValidation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Features.Schedules.Dtos
{
    public class ScheduleCreateDto
    {
       // [JsonIgnore]
        public int UserId { get; set; }
        public int AvailabilityId { get; set; }
        public int? PositionId { get; set; }
    }

    public class ScheduleCreateDtoValidator : AbstractValidator<ScheduleCreateDto>
    {
        public ScheduleCreateDtoValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty();

            RuleFor(x => x.AvailabilityId)
               .NotEmpty();
            
            //RuleFor(x => x.PositionId)
            //.NotEmpty();
        }
    }
}
