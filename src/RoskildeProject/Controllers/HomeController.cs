using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoskildeProject.Models;
using RoskildeProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.Net.Http.Headers;
using RoskildeProject.Data;
using RoskildeProject.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.IO;

namespace RoskildeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ViewResult> Index()
        {
             HomeViewModel hvm = new HomeViewModel();
            hvm.categories = await _context.categories.Where(c => c.name != null).Include(c => c.subCategories).ToListAsync();
            /*
            var cList = _context.categories.Select(x => new { id = x.id, Value = x.name });
            var scList = _context.subCategories.Select(x => new { id = x.id, Value = x.id });
            model.categoryList = new SelectList(cList, "id", "value");
            model.subCategoryList = new SelectList(scList, "id", "value");
    */
            // return View(_context.categories.ToList());
            return View(hvm);
            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
