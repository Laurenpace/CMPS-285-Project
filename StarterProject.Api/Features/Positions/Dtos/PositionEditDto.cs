using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Features.Positions.Dtos
{
    public class PositionEditDto
    {        
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PositionEditDtoValidator : AbstractValidator<PositionEditDto>
    {
        public PositionEditDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}
