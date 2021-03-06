using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Bu inputu doldurun!")]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
