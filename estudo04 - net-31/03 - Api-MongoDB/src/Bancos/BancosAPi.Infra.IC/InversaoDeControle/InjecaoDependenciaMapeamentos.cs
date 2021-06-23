using BancosAPI.Servico.Mapeamentos;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BancosAPI.Infra.IC.InversaoDeControle
{
    public static class InjecaoDependenciaMapeamentos
    {

        /// <summary>
        /// Metodo de Extensão que será utilizado no ConfigureServices do Startup.cs
        /// Adciona as classe dos mapeamentos do AutoMaper
        /// services.AddAutoMapperConfig(Configuration);
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            // instalar o no projeto o AutoMapper.Extensions.Microsoft.DependencyInjection
            //***********************************************************************************
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile),
                 typeof(ViewModelToDomainMappingProfile));

        }
    }
}
