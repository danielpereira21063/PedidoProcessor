using PedidoProcessor.Services.DTOs;

namespace PedidoProcessor.Services.Interfaces
{
    public interface IPedidoService
    {
        Task CriarPedidoAsync(PedidoRequest request);
    }
}
