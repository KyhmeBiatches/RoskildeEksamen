using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RoskildeProject.Models.ItemViewModels
{
    public class CreateViewModel
    {
        [Required]
        [Display(Name = "Titel")]
        public string title { get; set; }

        [Required]
        [Display(Name = "Pris")]
        public double price { get; set; }

        [Required]
        [MinLength(20)]
        [MaxLength(5000)]
        [Display(Name = "Beskrivelse")]
        public string description { get; set; }

        [Display(Name = "Kategori")]
        public string category { get; set; }

        public SelectList categoryList { get; set; }
        [Display(Name = "Underkategori")]
        public string subCategory { get; set; }
        public SelectList subCategoryList { get; set; }

        [Display(Name = "Stand")]
        public string condition { get; set; }
        public SelectList conditionList { get; set; }
        [Display(Name = "Overdragelse")]
        public string deliveryMethod { get; set; }
        public SelectList deliveryMethodList { get; set; }
    }
}
