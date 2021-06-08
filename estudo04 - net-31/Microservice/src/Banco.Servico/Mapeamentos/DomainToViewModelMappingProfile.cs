using AutoMapper;
using Sistema.Application.ViewModels;
using Sistema.Domain.Models;

namespace Sistema.Application.Mappings
{
    /// <summary>
    /// Classe do AUTOMAPPER para mapeamento de classe.
    /// </summary>
    public class DomainToViewModelMappingProfile : Profile
    {
        /// <summary>
        /// Mapear Model do Domain para ViewModel 
        /// considerando que o atributos da Model e ViewModel estão com mesmo nome
        /// </summary>
        public DomainToViewModelMappingProfile()
        {
            // Mapear Banco para BancoViewModel
            //************************************************
            CreateMap<Empresa, EmpresaViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Banco, BancoResposta>();
            CreateMap<Convenio, ConvenioViewModel>();

        }
    }
}
