using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Varchar(30)")]
        public string Name { get; set; }

        public int SupplierId { get; set; }
        public Vendor Vendor { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public int QuantityPerUnit { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }

        [Required]
        public int UnitsInStock { get; set; }

        [Required]
        public int UnitsOnOrder { get; set; }

        [Required]
        public bool Discontinued { get; set; }
    }
}
