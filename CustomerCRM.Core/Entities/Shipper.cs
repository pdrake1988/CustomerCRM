using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Entities
{
    public class Shipper
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "Varchar(15)")]
        public string Phone { get; set; }
    }
}
