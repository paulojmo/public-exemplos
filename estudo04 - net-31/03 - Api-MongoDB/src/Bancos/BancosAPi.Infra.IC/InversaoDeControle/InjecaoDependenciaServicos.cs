using BancosAPI.Servico.Interfaces;
using BancosAPI.Servico.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace BancosAPI.Infra.IC.InversaoDeControle
{
    public static class InjecaoDependenciaServicos
    {
        /// <summary>
        /// Metodo de Extensão que será utilizado no ConfigureServices do Startup.cs
        /// Adciona as classe da camada Application
        /// services.AddApplication(Configuration);
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddServicos(this IServiceCollection services)
        {

            // Interface e os Services
            // Sistema.Application.Interfaces e Sistema.Application.Services
            //***********************************************************************************
            services.AddScoped<IBancoServico, BancoServico>();


            return services;
        }
    }
}
