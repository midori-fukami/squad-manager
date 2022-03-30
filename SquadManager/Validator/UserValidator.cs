using FluentValidation;

using SquadManager.Models;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email).NotNull().WithMessage("E-mail vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("O e-mail está inválido");
            RuleFor(user => user.Password).NotNull().WithMessage("Digite a senha");
        }
    }
}
