using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.Models
{
    public class EmailSection
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        public string SuccesMsg { get; set; }
        public string ErrorMsg { get; set; }
    }
}
