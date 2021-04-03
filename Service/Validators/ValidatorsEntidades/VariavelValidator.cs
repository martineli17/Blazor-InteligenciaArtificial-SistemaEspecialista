using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using FluentValidation;
using Service.Validators.MessagensValidator;

namespace Service.Validators.ValidatorsEntidades
{
    public class VariavelValidator : AbstractValidator<Variavel>
    {
        public VariavelValidator()
        {
            RuleFor(x => x.IdProjeto).NotEmpty().WithMessage("Necessário selecionar um projeto.");
            RuleFor(x => x.Nome).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Nome"))
                .MaximumLength(50).WithMessage(MensagemValidator.NaoMaior("Nome"));
            RuleFor(x => x.Objetivo).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Objetivo"))
                .NotNull().WithMessage(MensagemValidator.NaoNuloOuVazio("Objetivo"));
            RuleFor(x => x.Pergunta).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Pergunta"))
                .MaximumLength(250).WithMessage(MensagemValidator.NaoMaior("Pergunta"));
            RuleFor(x => x.MotivoPergunta).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Motivo Pergunta"))
                .MaximumLength(50).WithMessage(MensagemValidator.NaoMaior("Motivo Pergunta"));
        }
    }
}
