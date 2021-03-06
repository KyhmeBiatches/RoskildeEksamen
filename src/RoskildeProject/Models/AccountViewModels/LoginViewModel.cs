﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoskildeProject.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Kodeord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Husk mig?")]
        public bool RememberMe { get; set; }
    }
}
