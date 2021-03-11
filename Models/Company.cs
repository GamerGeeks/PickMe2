using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PickMe2.Models
{
    public class Company
    {
        [Required(ErrorMessage = "Enter Company Name")]
        [Display(Name = "Company Name")]
        public string Company_name { get; set; }
        [Required(ErrorMessage = "Enter Company Address")]
        [Display(Name = "Company Address")]
        public string Company_address { get; set; }
        [Required(ErrorMessage = "Enter Company Vendor Name")]
        [Display(Name = "Company Vendor Name")]
        public string Company_vendor_name { get; set; }
        [Required(ErrorMessage = "Enter Company Email")]
        [Display(Name = "Company Email")]
        public string Company_email { get; set; }
        [Required(ErrorMessage = "Enter Company Contact")]
        [Display(Name = "Company Contact")]
        public string Company_contact { get; set; }

    }
}