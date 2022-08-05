using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Varchar(30)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "Varchar(30)")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "Varchar(30)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "Varchar(30)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int PostalCode { get; set; }

        [Required]
        [Column(TypeName = "Varchar(20)")]
        public string Country { get; set; }

        [Required]
        [Column(TypeName = "Varchar")]
        public string Phone { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string Photo { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
