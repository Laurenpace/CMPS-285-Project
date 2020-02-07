using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Features.Users.Dtos
{
    public class UserEditDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class UserEditDtoValidator : AbstractValidator<UserEditDto>
    {
        public UserEditDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty();

            RuleFor(x => x.LastName)
                .NotEmpty();

            RuleFor(x => x.Username)
                .NotEmpty();

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(x => x.Address)
                .NotEmpty();

            RuleFor(x => x.City)
                .NotEmpty();

            RuleFor(x => x.State)
                .NotEmpty();

            RuleFor(x => x.ZipCode)
                .NotEmpty();
 
            RuleFor(x => x.PhoneNumber)
                .NotEmpty();
        }
    }
}
