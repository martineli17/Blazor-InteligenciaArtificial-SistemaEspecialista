using Dominio.Entidades;
using FluentValidation;
using Service.Validators.MessagensValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Validators.ValidatorsEntidades
{
    public class RegraValidator : AbstractValidator<Regra>
    {
        public RegraValidator()
        {
            RuleFor(x => x.RegrasVariavel).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Regras Variável"))
                .NotNull().WithMessage(MensagemValidator.NaoNuloOuVazio("Regras Variável"));
            RuleFor(x => x.IdVariavelObjetivo).NotEmpty().WithMessage(MensagemValidator.ErroNoProcesso);
            RuleFor(x => x.ValorVariavelObjetivo).NotEmpty().WithMessage(MensagemValidator.NaoNuloOuVazio("Valor Variável Objetivo"))
                .NotNull().WithMessage(MensagemValidator.NaoNuloOuVazio("Valor Variável Objetivo"))
                .MaximumLength(250).WithMessage(MensagemValidator.NaoMaior("Valor Variável Objetivo"));
            RuleFor(x => x.Complemento).NotNull().WithMessage(MensagemValidator.NaoNuloOuVazio("Complemento"));
        }
    }
}
