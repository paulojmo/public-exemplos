using Compartilhado.Entidades;
using Compartilhado.OData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Compartilhado.InterfaceBase
{
    /// <summary>
    /// Repositório Base (CRUD).
    /// </summary>
    /// <typeparam name="TEntidade">A entidade a ser manipulada.</typeparam>
    public interface IRepositorioBase<TEntidade> : IRepositorio
        //where TEntidade : LongEntidadeChave, IRaizAgregada
    {
        #region Escrita

        /// <summary>
        /// Adiciona a entidade na transação para ser criada.
        /// </summary>
        /// <param name="entidade">A entidade a ser adicionada.</param>
        void Adicionar(TEntidade entidade);

        /// <summary>
        /// Adiciona uma lista de entidades na transação para serem criadas.
        /// </summary>
        /// <param name="entidades">A lista de entidades.</param>
        void AdicionarLista(IEnumerable<TEntidade> entidades);

        /// <summary>
        /// Adiciona a entidade na transação para ser atualizada.
        /// </summary>
        /// <param name="entidade">A entidade a ser atualizado.</param>
        void Atualizar(TEntidade entidade);

        /// <summary>
        /// Adiciona a entidade na transação para ser removida.
        /// </summary>
        /// <param name="entidade">A entidade a ser removida.</param>
        void Remover(TEntidade entidade);

        /// <summary>
        /// Adiciona uma lista de entidades na transação para serem removidas.
        /// </summary>
        /// <param name="entidades">A lista de entidades.</param>
        void RemoverLista(IEnumerable<TEntidade> entidades);

        /// <summary>
        /// Confirma a transação na base de dados.
        /// </summary>
        /// <returns>Número de linhas afetadas.</returns>
        Task<int> SalvarAlteracoesAsync();

        #endregion

        #region Leitura

        /// <summary>
        /// Obtém uma única entidade a partir do ID informado.
        /// </summary>
        /// <param name="id">Identificador da entidade.</param>
        /// <param name="somenteLeitura">Quando for verdadeiro, a entidade não será rastreada e não poderá ser feita a auditoria da mesma.</param>
        /// <returns>A entidade se a mesma existir; caso contrario, nulo(a).</returns>
        Task<TEntidade> ObterPorIdAsync(long id, bool somenteLeitura = true);

        /// <summary>
        /// Obtém uma lista de entidades paginadas.
        /// </summary>
        /// <param name="oDataParametros">Opções: filtro, ordenação, paginação</param>
        /// <returns>O resultado da paginação.</returns>
        //Task<PaginacaoResultado<TEntidade>> ObterPaginadoAsync(ODataParametros oDataParametros);
        #endregion
    }
}