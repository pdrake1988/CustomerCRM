using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        
        [Column(TypeName = "Varchar(30)")]
        public string Name { get; set; }
        
        [Column(TypeName = "int")]
        public int SupplierId { get; set; }
        
        [Column(TypeName = "int")]
        public int CategoryId { get; set; }
        
        [Column(TypeName = "int")]
        public int QuantityPerUnit { get; set; }

        [Column(TypeName = "int")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "int")]
        public int UnitsInStock { get; set; }

        [Column(TypeName = "int")]
        public int UnitsOnOrder { get; set; }

        [Column(TypeName = "int")]
        public bool Discontinued { get; set; }

        [Column(TypeName = "int")]
        public int VendorId { get; set; }
    }
}
