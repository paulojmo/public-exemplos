using FluentValidation;

namespace Upper.Aplicacao.Requisicoes.BancoRequisicoes
{
    public class BancoRequisicaoValidador : AbstractValidator<BancoRequisicao>
    {
        public BancoRequisicaoValidador()
        {
            RuleFor(banco => banco.RazaoSocial)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(banco => banco.Observacao)
                .MaximumLength(100);

            RuleFor(banco => banco.Numero)
                .MaximumLength(5);
        }
    }
}
