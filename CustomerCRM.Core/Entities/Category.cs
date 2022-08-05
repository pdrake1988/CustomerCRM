using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrm.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "Varchar(20)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "Varchar(80)")]
        public string Description { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
