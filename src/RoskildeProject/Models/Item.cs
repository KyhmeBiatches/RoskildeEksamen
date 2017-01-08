using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoskildeProject.Models
{
    public class Item
    {
        public int id { get; set; }
        [Display(Name = "Titel")]
        public string title { get; set; }
        [Display(Name = "Pris")]
        public double price { get; set; }
        [Display(Name = "Oprettet")]
        public DateTime created_at { get; set; }
        [Display(Name = "Beskrivelse")]
        public string description { get; set; }
        [Display(Name = "Sælger")]
        public ApplicationUser creator { get; set; }
        [Display(Name = "Kategori")]
        public Category category { get; set; }
        [Display(Name = "Underkategori")]
        public SubCategory subCategory { get; set; }
        public ICollection<Picture> pictures { get; set; }
        public ICollection<Comment> comments { get; set; }
        public ICollection<DeliveryMethod> deliveryMethods { get; set; }
        public Condition condition { get; set; }

        public string getFormatedDate()
        {
            string dateStr = "";
            if (DateTime.Now.Year == created_at.Year && DateTime.Now.DayOfYear == created_at.DayOfYear)
            {
                dateStr = "I dag";
            }else if ((DateTime.Now.Year == created_at.Year && DateTime.Now.DayOfYear == (created_at.DayOfYear + 1)))
            {
                dateStr = "I går";
            }
            else
            {
                dateStr = created_at.ToString();
            }

            return(dateStr);
        }
    }
}
