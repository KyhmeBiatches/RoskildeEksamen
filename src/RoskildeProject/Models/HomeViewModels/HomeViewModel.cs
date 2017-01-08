using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoskildeProject.Controllers;

using RoskildeProject.Data;

using Microsoft.AspNetCore.Mvc;

namespace RoskildeProject.Models
{
    public class HomeViewModel
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public string name { get; set; }
        

        public List<Category> categories { get; set; }
        public SubCategory subCategory { get; set; }

      

    }
}
