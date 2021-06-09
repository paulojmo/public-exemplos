using Infraestrutura.Compartilhado;
using Upper.Dominio.Entidades.Financeiros;
using Upper.Dominio.Interfaces.Repositorios.Financeiros;
using Upper.Infraestrutura.Contexto;

namespace Upper.Infraestrutura.Repositorios.Financeiros
{
    public class BancoRepositorio : RepositorioBase<Banco>, IBancoRepositorio
    {
        public BancoRepositorio(UpperContexto contexto, UpperEdmContexto edmContexto)
            : base(contexto, edmContexto.Model)
        {
        }
    }
}
