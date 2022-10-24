using cineweb_orders_api.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cineweb_orders_api.DTO
{
    public class PedidoDTO
    {
        public int OrderId { get; set; }

        public Guid UserId { get; set; }

        public List<Guid> MovieId { get; set; }

        public decimal OrderAmount { get; set; }

        public StatusPedido Status { get; set; }
    }
}
