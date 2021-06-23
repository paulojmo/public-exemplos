using BancosAPI.Dominio.Entidades;
using BancosAPI.Dominio.Interfaces;
using BancosAPI.Infra.Data.Contexto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancosAPI.Infra.Data.Repositorios
{
    /// <summary>
    /// Classe dos Repositorios de dados
    /// </summary>
    public class BancoRepositorio : IBancoRepositorio
    {
        private SistemaContexto _contexto;
        public BancoRepositorio(SistemaContexto contexto)
        {

            _contexto = contexto;

        }

        public Task<IEnumerable<BancoEntidade>> GetLista()
        {
            throw new System.NotImplementedException();
        }

        //public Task<IEnumerable<BancoEntidade>> GetLista()
        //{

        //   return _contexto.Bancos.Find(_ => true).ToListAsync();

        //}



        /*
        public async Task<IEnumerable<BancoEntidade>> GetLista(string CampoParaFiltro, string ValorParaFiltro)
        {
            string cValor = ValorParaFiltro;

            //quando o ValorParaFiltro estiver VAZIO o CampoParaFiltro tambem deve ser vazio.
            //*************************************************************************************
            string cFiltro = !string.IsNullOrEmpty(ValorParaFiltro) ? CampoParaFiltro : string.Empty;

            //criar uma queryList para consulta.
            //***********************************************************
            IEnumerable<BancoEntidade> QueryList;

            //verifica as opções para filtro...
            //***********************************************************
            switch (cFiltro)
            {
                case "ID": //ID                    
                    QueryList = await _contexto.Bancos.Where(s => s.ID.Contains(cValor)).OrderBy(s => s.ID).ToListAsync();

                    break;
                case "Nome": //Nome
                    QueryList = await _contexto.Bancos.Where(s => s.Nome.Contains(cValor)).OrderBy(s => s.Nome).ToListAsync();
                    //queryList = queryList.Where(s => s.Nome.Contains(buscaParam) || s.Fantasia.Contains(buscaParam));

                    break;
                case "Fantasia": //Fantasia
                    QueryList = await _contexto.Bancos.Where(s => s.Fantasia.Contains(cValor)).OrderBy(s => s.Fantasia).ToListAsync();

                    break;
                default: //lista todos os registros.
                    QueryList = await _contexto.Bancos.Where(s => s.EmpresaID != "00").OrderBy(s => s.Nome).ToListAsync();

                    break;
            }

            //return await _contexto.Bancos.ToListAsync();
            return QueryList;

        }

        public async Task<bool> ExistID(string id)
        {

            return await _contexto.Bancos.AnyAsync(e => e.ID == id);

        }

        public async Task<BancoEntidade> GetID(string id)
        {

            return await _contexto.Bancos.FindAsync(id);

        }

        public async Task<int> Add(BancoEntidade item)
        {

            _contexto.Add(item);
            return await _contexto.SaveChangesAsync();

        }

        public async Task<int> Delete(BancoEntidade item)
        {

            _contexto.Remove(item);
            return await _contexto.SaveChangesAsync();

        }

        public async Task<int> Update(BancoEntidade item)
        {

            _contexto.Update(item);
            return await _contexto.SaveChangesAsync();

        }
        */
    }

}
