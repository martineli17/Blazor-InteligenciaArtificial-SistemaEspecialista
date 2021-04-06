using Dominio.Entidades;
using FluentValidation;
using Service.Validators.MessagensValidator;

namespace Service.Validators.ValidatorsEntidades
{
    public class RegraVariavelValidator : AbstractValidator<RegraVariavel>
    {
        public RegraVariavelValidator()
        {

            RuleFor(x => x.IdVariavel).NotEmpty().WithMessage(MensagemValidator.ErroNoProcesso);
            RuleFor(x => x.IdRegra).NotEmpty().WithMessage(MensagemValidator.ErroNoProcesso);
            RuleFor(x => x.ValorVariavel).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Valor variável"))
                .MaximumLength(250).WithMessage(MensagemValidator.NaoMaior("Valor variável"));
        }
    }
}
