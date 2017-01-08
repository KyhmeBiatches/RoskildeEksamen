using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoskildeProject.Models.Profile
{
    public class EditProfileViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Du skal tilføje din email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Du skal tilføje dit fornavn")]
        [Display(Name = "Fornavn")]
        public string fName { get; set; }

        [Required(ErrorMessage = "Du skal tilføje dit efternavn(e)")]
        [Display(Name = "Efternavn(e)")]
        public string lName { get; set; }

        [Required(ErrorMessage = "Du skal tilføje dit postnummer")]
        [RegularExpression(@"^\(?([0-9]{4})\)?$", ErrorMessage = "Ikke et valid postnummer")]
        [Display(Name = "Postnr.")]
        public int postal { get; set; }

        [Required]
        [Display(Name = "Adresse")]
        public string address { get; set; }

        [Required(ErrorMessage = "Du skal tilføje dit telefonnummer")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{8})\)?$", ErrorMessage = "Ikke et valid telefonnummer")]
        [Display(Name = "Telefonnr.")]
        public string phoneNumber { get; set; }
    }
}
