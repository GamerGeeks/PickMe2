using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PickMe2.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Enter Company ID")]
        [Display(Name = "Enter Company ID")]
        public string Company_id { get; set; }
        [Required(ErrorMessage = "Enter First Name")]
        [Display(Name = "Enter First Name")]
        public string Emp_fname { get; set; }
        [Required(ErrorMessage = "Enter Last Name")]
        [Display(Name = "Enter Last Name")]
        public string Emp_lname { get; set; }
        [Required(ErrorMessage = "Contact")]
        [Display(Name = "Contact")]
        public string Emp_contact { get; set; }
        [Required(ErrorMessage = "Email ID")]
        [Display(Name = "Email ID")]
        public string Emp_email { get; set; }
        [Required(ErrorMessage = "Address")]
        [Display(Name = "Address")]
        public string Emp_address { get; set; }

    }
}