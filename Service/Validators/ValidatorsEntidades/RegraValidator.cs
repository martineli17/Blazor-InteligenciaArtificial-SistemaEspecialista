using Dominio.Entidades;
using FluentValidation;
using Service.Validators.MessagensValidator;

namespace Service.Validators.ValidatorsEntidades
{
    public class RegraValidator : AbstractValidator<Regra>
    {
        public RegraValidator()
        {
            RuleFor(x => x.IdVariavelObjetivo).NotEmpty().WithMessage(MensagemValidator.ErroNoProcesso);
            RuleFor(x => x.ValorVariavelObjetivo).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Valor Variável Objetivo"))
                .NotNull().WithMessage(MensagemValidator.NaoNuloOuVazio("Valor Variável Objetivo"))
                .MaximumLength(250).WithMessage(MensagemValidator.NaoMaior("Valor Variável Objetivo"));
        }
    }
}
