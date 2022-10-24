using cineweb_orders_api.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cineweb_orders_api.Models
{
    [Table("pedido")]
    public class Pedido
    {
        public Pedido() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPedido { get; set; }

        public Guid UsuarioId { get; set; }

        public Guid FilmeId { get; set; }

        public decimal ValorPedido { get; set; }

        public StatusPedido Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? PaymentDate { get; set; }
    }
}
