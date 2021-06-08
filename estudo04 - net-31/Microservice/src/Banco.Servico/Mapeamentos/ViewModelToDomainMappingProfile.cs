using AutoMapper;
using Sistema.Application.ViewModels;
using Sistema.Domain.Models;

namespace Sistema.Application.Mappings
{
    /// <summary>
    /// Classe do AUTOMAPPER para mapeamento de classe.
    /// </summary>
    public class ViewModelToDomainMappingProfile : Profile
    {
        /// <summary>
        /// Mapear ViewModel para o Model do Domain
        /// considerando que o atributos da Model e ViewModel estão com mesmo nome
        /// </summary>
        public ViewModelToDomainMappingProfile()
        {

            // Ex.: Mapear BancoViewModel para Banco
            //************************************************
            CreateMap<EmpresaViewModel, Empresa>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<BancoResposta, Banco>();
            CreateMap<ConvenioViewModel, Convenio>();

        }


    }
}
