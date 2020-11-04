using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SurveyCo.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
