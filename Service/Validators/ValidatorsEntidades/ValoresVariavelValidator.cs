using Dominio.Entidades;
using FluentValidation;
using Service.Validators.MessagensValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Validators.ValidatorsEntidades
{
    public class ValoresVariavelValidator : AbstractValidator<ValoresVariavel>
    {
        public ValoresVariavelValidator()
        {
            RuleFor(x => x.IdVariavel).NotEmpty().WithMessage(MensagemValidator.ErroNoProcesso);
            RuleFor(x => x.Valor).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Valor"))
                .MaximumLength(250).WithMessage(MensagemValidator.NaoMaior("Valor"));

        }
    }
}
