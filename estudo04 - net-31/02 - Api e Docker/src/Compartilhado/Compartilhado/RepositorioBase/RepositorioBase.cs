using Compartilhado;
using Compartilhado.Entidades;
using Compartilhado.InterfaceBase;
using Compartilhado.OData;
using Infraestrutura.Compartilhado.Extensoes.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Compartilhado.Infra.RepositorioBase
{
    public abstract class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> 
        //where TEntidade : LongEntidadeChave, IRaizAgregada
    {
        #region Construtor

        protected readonly DbSet<TEntidade> DbSet;
        private readonly DbContext _context;
        //private readonly IEdmModel _edmModel;

        protected RepositorioBase(DbContext context) //, IEdmModel edmModel)
        {
            _context = context;
            DbSet = context.Set<TEntidade>();
            _edmModel = edmModel;
        }

        #endregion

        #region Escrita

        public void Adicionar(TEntidade entidade)
        {
            DbSet.Add(entidade);
        }

        public void AdicionarLista(IEnumerable<TEntidade> entidades)
        {
            DbSet.AddRange(entidades);
        }

        public void Atualizar(TEntidade entidade)
        {
            DbSet.Update(entidade);
        }

        public void Remover(TEntidade entidade)
        {
            DbSet.Remove(entidade);
        }

        public void RemoverLista(IEnumerable<TEntidade> entidades)
        {
            DbSet.RemoveRange(entidades);
        }

        public Task<int> SalvarAlteracoesAsync()
        {
            return _context.SaveChangesAsync();
        }

        #endregion

        #region Leitura

        public virtual Task<TEntidade> ObterPorIdAsync(long id, bool somenteLeitura = true)
        {
            var query = somenteLeitura ? DbSet.AsNoTracking() : DbSet.AsTracking();
            return query.FirstOrDefaultAsync(entidade => entidade.Id == id);
        }

        public virtual Task<PaginacaoResultado<TEntidade>> ObterPaginadoAsync(ODataParametros oDataParametros)
        {
            return DbSet.AplicarQueryOptionsAsync(oDataParametros, _edmModel);
        }

        #endregion
    }
}