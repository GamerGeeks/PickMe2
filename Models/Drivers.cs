using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PickMe2.Models
{
    public class Drivers
    {
        [Required(ErrorMessage = "Enter Driver Name")]
        [Display(Name = "Enter Driver Name")]
        public string Driver_name { get; set; }
        [Required(ErrorMessage = "Enter Company ID")]
        [Display(Name = "Enter Company ID")]
        public string Driver_address { get; set; }
        [Required(ErrorMessage = "Enter Company ID")]
        [Display(Name = "Enter Company ID")]
        public string Driver_pan { get; set; }
        [Required(ErrorMessage = "Enter Company ID")]
        [Display(Name = "Enter Company ID")]
        public string Driver_license { get; set; }
        [Required(ErrorMessage = "Enter Company ID")]
        [Display(Name = "Enter Company ID")]
        public string Comapny_contact { get; set; }
        [Required(ErrorMessage = "Enter Company ID")]
        [Display(Name = "Enter Company ID")]
        public string Driver_photo { get; set; }

    }
}