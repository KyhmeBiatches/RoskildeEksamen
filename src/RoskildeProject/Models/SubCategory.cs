using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoskildeProject.Models
{
    public class SubCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public Category category { get; set; }
    }
}
