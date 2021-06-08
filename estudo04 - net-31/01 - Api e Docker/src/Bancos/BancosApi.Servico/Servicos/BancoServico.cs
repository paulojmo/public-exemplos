﻿using AutoMapper;
using BancosAPI.Servico.Interfaces;
using BancosAPI.Servico.Respostas;
using BancosAPI.Dominio.Interfaces;
using BancosAPI.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancosAPI.Servico.Servicos
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
        private readonly IMapper _mapper;

        /// <summary>
        /// contrutor da classe BancoService
        /// </summary>
        public BancoServico(IMapper mapper, IBancoRepositorio bancoRepository)
        {
            // injeção de dependencia do repositorio
            //***********************************************************************************************
            _bancoRepository = bancoRepository;

            // injeção de dependencia do autoMapper
            // utilizado para mapear as classe do dominio para as classes viewModel
            //***********************************************************************************************
            _mapper = mapper;

        }

        public async Task<IEnumerable<BancoResposta>> GetLista()
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            var result = await _bancoRepository.GetLista();

            // mapear o RESULT para a ViewModel 
            //***********************************************************************************************
            return _mapper.Map<IEnumerable<BancoResposta>>(result);
        }


        public async Task<IEnumerable<BancoResposta>> GetLista(string CampoParaFiltro, string ValorParaFiltro)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            var result = await _bancoRepository.GetLista(CampoParaFiltro, ValorParaFiltro);

            // mapear o RESULT para a ViewModel 
            //***********************************************************************************************
            return _mapper.Map<IEnumerable<BancoResposta>>(result);
        }

        public async Task<BancoResposta> GetID(string codigo)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            var result = await _bancoRepository.GetID(codigo);

            // mapear o RESULT para a ViewModel 
            //***********************************************************************************************
            return _mapper.Map<BancoResposta>(result);

        }
        public int Add(BancoResposta item)
        {
            // mapear o ViewModel para a Classe do Dominio
            //***********************************************************************************************
            var mapBanco = _mapper.Map<BancoEntidade>(item);

            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return _bancoRepository.Add(mapBanco);
        }

        public int Delete(string codigo)
        {
            var result = _bancoRepository.GetID(codigo).Result;

            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return _bancoRepository.Delete(result);
        }

        public int Update(BancoResposta item)
        {
            // mapear o ViewModel para a Classe do Dominio
            //***********************************************************************************************
            var mapBanco = _mapper.Map<BancoEntidade>(item);

            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return _bancoRepository.Update(mapBanco);
        }

        public bool ExistID(string codigo)
        {
            // usar o repositorio para realizar a operação
            //***********************************************************************************************
            return _bancoRepository.ExistID(codigo);

        }


    }
}
