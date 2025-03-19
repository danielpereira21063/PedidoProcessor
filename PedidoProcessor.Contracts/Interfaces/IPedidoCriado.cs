namespace PedidoProcessor.Contracts.Interfaces
{
    public interface IPedidoCriado
    {
        Guid Id { get; }
        string Produto { get; }
        decimal Valor { get; }
        DateTime DataCriacao { get; }
    }
}
