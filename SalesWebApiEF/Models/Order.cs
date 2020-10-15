using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApiEF.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "Decimal(11, 2)")]
        public decimal Total { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime Created { get; set; } = DateTime.Now;
        public int CustomerId { get; set; }

       

         public Order()
        {

        }

    }
}
