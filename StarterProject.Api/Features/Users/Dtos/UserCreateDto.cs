using FluentValidation;

namespace StarterProject.Api.Features.Users.Dtos
{
    public class UserCreateDto
    {
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

    public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateDtoValidator()
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