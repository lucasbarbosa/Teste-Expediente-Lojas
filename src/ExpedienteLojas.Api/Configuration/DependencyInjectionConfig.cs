using ExpedienteLojas.Negocio.Classes;
using ExpedienteLojas.Negocio.Interfaces;
using ExpedienteLojas.Negocio.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace ExpedienteLojas.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<IFuncionamentoLojasRepositorio, FuncionamentoLojasRepositorio>();
            services.AddScoped<IFuncionamentoLojas, FuncionamentoLojas>();

            return services;
        }
    }
}