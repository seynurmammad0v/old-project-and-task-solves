using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Models
{
    public class SliderFlorist
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

    }
}
