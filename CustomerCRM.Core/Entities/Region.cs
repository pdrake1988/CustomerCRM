using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Entities
{
    public class Region
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string Name { get; set; }
    }
}
