using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RoskildeProject.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string address { get; set; }
        public int postal { get; set; }
        public DateTime created_at { get; set; }

        public string getCreatedAtDate()
        {
            return created_at.Date.ToString("dd-MM-yyyy");
        }
    }
}
