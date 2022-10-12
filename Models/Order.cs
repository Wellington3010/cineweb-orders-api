using cineweb_orders_api.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cineweb_orders_api.Models
{
    [Table("order")]
    public class Order
    {
        public Order() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid MovieId { get; set; }

        public decimal OrderAmount { get; set; }

        public OrderStatusEnum Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? PaymentDate { get; set; }
    }
}
