using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApiEF.Models
{
    public class Orderline
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Product { get; set; }
        [Required]
        [Column(TypeName = "Decimal (11,2)")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(30)]
        public int Quantity { get; set; }
        public int OrderId { get; set; }
       
        

        public Orderline()
        {

        }
    }
}
