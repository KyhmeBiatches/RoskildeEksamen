using System.Collections.Generic;

namespace RoskildeProject.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<SubCategory> subCategories { get; set; }
    }
}