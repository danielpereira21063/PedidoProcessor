using MassTransit;
using PedidoProcessor.Contracts.Interfaces;
using PedidoProcessor.Domain.Models;
using PedidoProcessor.Services.DTOs;
using PedidoProcessor.Services.Interfaces;

namespace PedidoProcessor.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public PedidoService(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public async Task CriarPedidoAsync(PedidoRequest request)
        {
            var pedido = new Pedido(request.Produto, request.Valor, DateTime.Now);

            await _publishEndpoint.Publish<IPedidoCriado>(pedido);
        }
    }
}
