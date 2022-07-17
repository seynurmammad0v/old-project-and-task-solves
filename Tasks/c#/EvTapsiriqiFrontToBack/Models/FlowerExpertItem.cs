using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Models
{
    public class FlowerExpertItem
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
