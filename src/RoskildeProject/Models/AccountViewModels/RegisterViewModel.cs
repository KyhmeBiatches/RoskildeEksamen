using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoskildeProject.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Du skal tilføje din email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [StringLength(100, ErrorMessage = "Dit kodeord {0} skal være mindst {2} eller max {1} tegn langt.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Kodeord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekræft dit kodeord")]
        [Compare("Password", ErrorMessage = "Dit kodeord og din kodeords bekræftigelse passer ikke sammen.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Du skal tilføje dit fornavn")]
        [Display(Name ="Fornavn")]
        public string fName { get; set; }
    }
}
