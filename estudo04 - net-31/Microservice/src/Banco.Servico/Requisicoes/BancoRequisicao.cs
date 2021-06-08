using Aplicacao.Compartilhado.Requisicao;
using Infraestrutura.Compartilhado.Extensoes;

namespace Upper.Aplicacao.Requisicoes.BancoRequisicoes
{
    public class BancoRequisicao : EditavelRequisicao
    {
        public string ID { get; set; }

        public string Nome { get; set; }

        public string Fantasia { get; set; }

        public string EmpresaID { get; set; }

        public override void Validar()
        {
            this.ToNotifications(new BancoRequisicaoValidador().Validate(this));
        }
    }
}
