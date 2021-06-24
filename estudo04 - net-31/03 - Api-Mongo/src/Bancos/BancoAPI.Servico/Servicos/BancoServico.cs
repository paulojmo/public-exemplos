using BancoAPI.Dominio.Entidades;
using BancoAPI.Dominio.RepositorioInterfaces;
using BancoAPI.Servico.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancoAPI.Servico.Servicos
{
    /// <summary>
    /// BancosAPI.Servico
    /// </summary>
    public class BancoServico : IBancoServico
    {
        // propriedade do repositorio.
        //***********************************************************************************************
        private IBancoRepositorio _bancoRepository;

        // propriedade para o mapeamento
        //***********************************************************************************************
        //private readonly IMapper _mapper;

        /// <summary>
        /// contrutor da classe BancoService
        /// </summary>
        public BancoServico(/*IMapper mapper,*/ IBancoRepositorio bancoRepository)
        {
            // injeção de dependencia do repositorio
            //***********************************************************************************************
            _bancoRepository = bancoRepository;

            // injeção de dependencia do autoMapper
            // utilizado para mapear as classe do dominio para as classes viewModel
            //***********************************************************************************************
            //_mapper = mapper;

        }

        /// <summary>
        /// retorna a lista de bancos
        /// </summary>
        public async Task<IEnumerable<BancoEntidade>> GetLista()
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            var result = await _bancoRepository.GetLista();

            // mapear o RESULT para a ViewModel 
            //***********************************************************************************************
            //return _mapper.Map<IEnumerable<BancoResposta>>(result);
            return result; 
        }


        
        public async Task<BancoEntidade> GetID(string codigo)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            var result = await _bancoRepository.GetID(codigo);

            // mapear o RESULT para a ViewModel 
            //***********************************************************************************************
            //return _mapper.Map<BancoResposta>(result);
            return result; 

        }
        /*
        public async Task<int> Add(BancoResposta item)
        {
            // mapear o ViewModel para a Classe do Dominio
            //***********************************************************************************************
            var mapBanco = _mapper.Map<BancoEntidade>(item);

            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return await _bancoRepository.Add(mapBanco);
        }

        public async Task<int> Delete(string codigo)
        {
            var result = _bancoRepository.GetID(codigo).Result;

            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return await _bancoRepository.Delete(result);
        }

        public async Task<int> Update(BancoResposta item)
        {
            // mapear o ViewModel para a Classe do Dominio
            //***********************************************************************************************
            var mapBanco = _mapper.Map<BancoEntidade>(item);

            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return await _bancoRepository.Update(mapBanco);
        }

        public async Task<bool> ExistID(string codigo)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return await _bancoRepository.ExistID(codigo);

        }
        */

    }
}
