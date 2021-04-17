using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StateScholarshipProject.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "User Category")]
        public string UserCategory { get; set; }


    }
}