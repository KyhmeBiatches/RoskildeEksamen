using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoskildeProject.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string commentText { get; set; }
        public ApplicationUser author { get; set; }
        public DateTime created_at { get; set; }
        public Item item { get; set; }
    }
}
