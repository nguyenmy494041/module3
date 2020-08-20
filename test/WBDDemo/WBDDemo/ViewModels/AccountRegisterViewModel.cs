﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Passwork{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Passwork", ErrorMessage ="Comfirm passwork not macth")]
        public string ConfirmPasswork { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

    }
}
