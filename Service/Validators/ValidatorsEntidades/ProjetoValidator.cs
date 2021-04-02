using Dominio.Entidades;
using FluentValidation;
using Service.Validators.MessagensValidator;

namespace Service.Validators.ValidatorsEntidades
{
    public class ProjetoValidator : AbstractValidator<Projeto>
    {
        public ProjetoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Nome"))
                .MaximumLength(50).WithMessage(MensagemValidator.NaoMaior("Nome"));
            RuleFor(x => x.Descricao).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Descrição"))
                .MaximumLength(250).WithMessage(MensagemValidator.NaoMaior("Descrição")); ;
            RuleFor(x => x.Autor).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Autor"))
                .MaximumLength(50).WithMessage(MensagemValidator.NaoMaior("Autor")); ;
        }
    }
}
