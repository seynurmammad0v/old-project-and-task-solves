using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Models
{
    public class Sliders
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }

        [Required]
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required]
        [NotMapped]
        public IFormFile[] Photos { get; set; }
    }
}
