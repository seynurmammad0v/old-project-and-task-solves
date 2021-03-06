using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CamexAPI.Models
{
    public class RegisterBusiness
    {
        [Required, Range(1, 999999999)]
        public int CompanyRegistrationNumber { get; set; }
        [Required]
        public string CompanyName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string CheckPassword { get; set; }
        [Required]
        public int CityId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required, DataType(DataType.PhoneNumber), MaxLength(9), MinLength(9)]
        public string PhoneNumber { get; set; }
        [Required]
        public int OfficeId { get; set; }
        [Required]
        public bool IsTermsAccepted { get; set; }
    }
}
