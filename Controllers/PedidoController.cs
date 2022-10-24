using cineweb_orders_api.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cineweb_orders_api.Controllers
{
    [Route("order")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        public PedidoController()
        {

        }

        [Route("gerar")]
        [HttpPost]
        public IActionResult GerarPedido(PedidoDTO order)
        {

            return Ok();
        }

        // Deleta pedidos com status pendente do usuário com data de criação maior que três meses atrás.
        [Route("deletar-pedidos-pendentes")]
        [HttpDelete]
        public IActionResult GerarPedido(UsuarioDTO user)
        {

            return Ok();
        }

        [Route("teste-api")]
        [HttpGet]
        public IActionResult TesteApi()
        {

            return Ok();
        }
    }
}
