using Common;
using FluentValidation;

namespace API.Validator
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator() {
            RuleFor(person => person.Name).NotNull().WithMessage("Nome vazio");
            RuleFor(person => person.Email).NotNull().WithMessage("E-mail vazio");
            RuleFor(person => person.Email).EmailAddress().WithMessage("O e-mail está inválido");

        }
    }
}
