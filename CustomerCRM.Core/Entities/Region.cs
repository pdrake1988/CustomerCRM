using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Entities
{
    public class Region
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Varchar(20)")]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
