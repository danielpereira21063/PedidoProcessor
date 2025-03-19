namespace PedidoProcessor.Domain.Models
{
    public sealed class Pedido
    {
        public int Id { get; private set; }
        public string Produto { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCriacao { private get; set; }


        public Pedido(string produto, decimal valor, DateTime dataCriacao)
        {
            Produto = produto;
            Valor = valor;
            DataCriacao = dataCriacao;

            Validar();
        }

        private void Validar()
        {
            const decimal minValue = 0.01M;

            if (string.IsNullOrEmpty(Produto)) throw new ArgumentNullException();
            if (Valor < minValue) throw new ArgumentOutOfRangeException();
            if (DataCriacao <= DateTime.MinValue) throw new ArgumentOutOfRangeException();
        }
    }
}
