using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Models
{
    public class ValentineDescription
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Src { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
