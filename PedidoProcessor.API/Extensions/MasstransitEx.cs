using MassTransit;
using PedidoProcessor.Contracts.Interfaces;

namespace PedidoProcessor.API.Extensions
{
    public static class MassTransitEx
    {
        private const string RabbitMqHost = "rabbitmq";
        private const string RabbitMqUsername = "admin";
        private const string RabbitMqPassword = "admin";
        private const string PedidoExchange = "pedido-exchange";

        public static void ConfigureMassTransit(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq((context, config) =>
                {
                    ConfigureRabbitMqConnection(config);
                    ConfigureExchangeBindings(config);
                });
            });
        }

        private static void ConfigureRabbitMqConnection(IRabbitMqBusFactoryConfigurator config)
        {
            config.Host(RabbitMqHost, h =>
            {
                h.Username(RabbitMqUsername);
                h.Password(RabbitMqPassword);
            });
        }

        private static void ConfigureExchangeBindings(IRabbitMqBusFactoryConfigurator config)
        {
            config.Message<IPedidoCriado>(m => m.SetEntityName(PedidoExchange));
            config.Publish<IPedidoCriado>(x => x.ExchangeType = "direct");
        }
    }
}
