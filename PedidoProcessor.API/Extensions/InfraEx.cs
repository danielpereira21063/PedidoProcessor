using PedidoProcessor.Services;
using PedidoProcessor.Services.Interfaces;

namespace PedidoProcessor.API.Extensions
{
    public static class InfraEx
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPedidoService, PedidoService>();
        }
    }
}
