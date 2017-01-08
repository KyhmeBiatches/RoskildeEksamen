using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using RoskildeProject.Data;
using RoskildeProject.Models;
using RoskildeProject.Models.ItemViewModels;

namespace RoskildeProject.Controllers
{
    [Authorize]
    public class ItemsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ItemsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            return View(await _context.items.ToListAsync());
        }

        [AllowAnonymous]
        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.items.Where(m => m.id == id).Include(i => i.creator).FirstOrDefaultAsync();
            item.pictures = _context.pictures.Where(p => p.item.id == item.id).ToList();
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            var model = new CreateViewModel();

            var conditionList = _context.conditions.Select(x => new {Id = x.id, Value = x.name});
            var dList = _context.deliveryMethods.Select(x => new {Id = x.id, Value = x.name});
            var cList = _context.categories.Select(x => new {Id = x.id, Value = x.name});
            var subList = _context.subCategories.Select(x => new {Id = x.id, Value = x.name});
            model.categoryList = new SelectList(cList, "Id", "Value");
            model.subCategoryList = new SelectList(subList, "Id", "Value");
            model.conditionList = new SelectList(conditionList, "Id", "Value");
            model.deliveryMethodList = new SelectList(dList, "Id", "Value");
            return View(model);
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateViewModel vm, IList<IFormFile> files)
        {
            Item item = new Item { price = vm.price, description = vm.description, title = vm.title, pictures = new List<Picture>(), deliveryMethods = new List<DeliveryMethod>() };
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);
            if (ModelState.IsValid)
            {
                long size = 0;
                foreach (var file in files)
                {
                    Picture picture = new Picture();
                    picture.owner = user;
                    var filename = ContentDispositionHeaderValue
                                    .Parse(file.ContentDisposition)
                                    .FileName
                                    .Trim('"');
                    Regex.Replace(filename, @"\s+", "");
                    var newFilename = _hostingEnvironment.WebRootPath + $@"\user-pictures\{filename}";
                    size += file.Length;
                    using (FileStream fs = System.IO.File.Create(newFilename))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                        picture.imagePath = @"user-pictures/" + filename;
                    }
                    _context.pictures.Add(picture);
                    item.pictures.Add(picture);
                }

                item.creator = user;
                item.created_at = DateTime.Now;
                item.deliveryMethods.Add(_context.deliveryMethods.Where(d => d.id.ToString() == vm.deliveryMethod).FirstOrDefault());
                item.category = _context.categories.Where(c => c.id.ToString() == vm.category).FirstOrDefault();
                item.subCategory = _context.subCategories.Where(c => c.id.ToString() == vm.subCategory).FirstOrDefault();
                item.condition = _context.conditions.Where(c => c.id.ToString() == vm.condition).FirstOrDefault();
                item = _context.Add(item).Entity;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Profile");
            }
            return View(vm);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.items.SingleOrDefaultAsync(m => m.id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,created_at,description,name,price")] Item item)
        {
            if (id != item.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.items.SingleOrDefaultAsync(m => m.id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.items.SingleOrDefaultAsync(m => m.id == id);
            _context.items.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        // GET: Items/Search/5
        public async Task<IActionResult> Search(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.items.Where(m => m.title.Contains(id)).Include(i => i.creator).Include(p => p.pictures).OrderByDescending(i => i.created_at).ToListAsync();
            ViewBag.Search = id;
            return View(items);
        }

        private bool ItemExists(int id)
        {
            return _context.items.Any(e => e.id == id);
        }
    }
}
