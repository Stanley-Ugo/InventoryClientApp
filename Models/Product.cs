using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryClientApp.Models
{
    //Products Model Class
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ProdId { get; set; }

        [Required]
        public string ProdName { get; set; }

        [Required]
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQty { get; set; }
    }
}
