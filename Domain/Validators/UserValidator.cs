using FluentValidation;

namespace Domain.Validators {
    class UserValidator : AbstractValidator<User> {

        public UserValidator() {
            RuleFor(x => x)
                .NotEmpty().WithMessage("O usuário não pode ser vazio.")
                .NotNull().WithMessage("O usuário não pode ser nulo.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("O nome não pode ser nulo.")
                .NotEmpty().WithMessage("O nome não pode ser vazio.")
                .MinimumLength(3).WithMessage("O nome precisa ter mais de 6 caracteres.")
                .MaximumLength(80).WithMessage("O nome deve ter no máximo 80 caracteres.");

            RuleFor(x => x.Email)
                .NotNull().WithMessage("O e-mail não pode ser nulo.")
                .NotEmpty().WithMessage("O e-mail não pode ser vazio.")
                .MinimumLength(10).WithMessage("O e-mail precisa ter mais de 10 caracteres.")
                .MaximumLength(180).WithMessage("O e-mail deve ter no máximo 80 caracteres.")
                
                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O e-mail informado não é válido.");

            RuleFor(x => x.Password)
                .NotNull().WithMessage("A senha não pode ser nula.")
                .NotEmpty().WithMessage("A senha não pode ser vazia.")
                .MinimumLength(6).WithMessage("A senha precisa ter mais de 6 caracteres.")
                .MaximumLength(80).WithMessage("A senha deve ter no máximo 80 caracteres.");
        }

    }
}
