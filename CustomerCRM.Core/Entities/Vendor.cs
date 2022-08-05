using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Entities
{
    public class Vendor
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Country { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Mobile { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
