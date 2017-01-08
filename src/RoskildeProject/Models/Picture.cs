using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoskildeProject.Models
{
    public class Picture
    {
        public int id { get; set; }
        public string imagePath { get; set; }
        public ApplicationUser owner { get; set; }
        public Item item { get; set; }
        
    }
}
