﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StateScholarshipProject.Models
{
    public class ForgotUserID
    {
        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "Favourite Pet")]
        public string FavouritePet { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "Favourite Movie")]
        public string FavouriteMovie { get; set; }

        [Required(ErrorMessage = "Please Update the highlighted mandatory field(s)")]
        [Display(Name = "Lucky Number")]
        public int LuckyNumber { get; set; }
    }
}