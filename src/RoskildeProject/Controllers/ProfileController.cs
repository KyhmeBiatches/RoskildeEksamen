using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RoskildeProject.Data;
using RoskildeProject.Models;
using RoskildeProject.Models.Profile;

namespace RoskildeProject.Controllers
{
    public class ProfileController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ProfileController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<ViewResult> Index()
        {
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);
            var items = _context.items.Where(i => i.creator.Id == user.Id).OrderByDescending(i => i.created_at);
            foreach (var item in items)
            {
                item.pictures = _context.pictures.Where(i => i.item.id == item.id).ToList();
            }
            return View(items);
        }

        public async Task<ViewResult> Edit()
        {
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);
            EditProfileViewModel vm = new EditProfileViewModel();
            vm.Id = user.Id;
            vm.Email = user.Email;
            vm.fName = user.fName;
            vm.lName = user.lName;
            vm.phoneNumber = user.PhoneNumber;
            vm.address = user.address;
            vm.postal = user.postal;
            return View(vm);
        }

        [HttpPost]
        public async Task<RedirectToActionResult> Edit(EditProfileViewModel vm)
        {
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);
            if (user.Id != vm.Id)
            {
                return RedirectToAction("Index", "Home");
            }
            user.Email = vm.Email;
            user.fName = vm.fName;
            user.lName = vm.lName;
            user.PhoneNumber = vm.phoneNumber;
            user.address = vm.address;
            user.postal = vm.postal;

            await _userManager.UpdateAsync(user);

            return RedirectToAction("Index");
        }
    }
}