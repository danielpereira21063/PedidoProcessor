using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoProcessor.Services.DTOs
{
    public class PedidoRequest
    {
        public string Produto { get; set; } = string.Empty;
        public decimal Valor { get; set; }
    }
}
