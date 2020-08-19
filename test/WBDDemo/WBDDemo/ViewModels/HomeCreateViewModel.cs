using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WBDDemo.Models;

namespace WBDDemo.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required(ErrorMessage = "Fullname cannot be blank")]
        [MaxLength(18, ErrorMessage = "Fullname maximum 18 characters")]
        public string Fullname { get; set; }
        [Required]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
            ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public IFormFile Avata { get; set; }
    }
}
