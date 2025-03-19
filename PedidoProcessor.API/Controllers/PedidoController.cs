using Microsoft.AspNetCore.Mvc;
using PedidoProcessor.Services.DTOs;
using PedidoProcessor.Services.Interfaces;

namespace PedidoProcessor.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    private readonly IPedidoService _pedidoService;

    public PedidoController(IPedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PedidoRequest request)
    {
        await _pedidoService.CriarPedidoAsync(request);
        return Accepted(new {Message = "Pedido enviado para a exchange..."});
    }
}
