using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoskildeProject.Data;
using RoskildeProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoskildeProject.Controllers
{
    [Produces("application/json")]
    [Route("api/ItemsApi")]
    public class ItemsApiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemsApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemsApi
        [HttpGet]
        public IEnumerable<Item> Getitems()
        {
            return _context.items;
        }

        // GET: api/ItemsApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Item item = await _context.items.SingleOrDefaultAsync(m => m.id == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // GET: api/ItemsApi/
        [Route("get/LastAdded")]
        [HttpGet]
        public List<Item> GetRecentlyAddedItems()
        {
            List<Item> items = (List<Item>)_context.items.OrderByDescending(i => i.created_at).Take(5).ToList();
            for(int i = 0; i < items.Count; i++)
            {
                Item item = items[i];
                items[i].pictures = new List<Picture>();
                if (_context.pictures.Where(p => p.item.id == item.id).Count() == 0 || _context.pictures.Where(p => p.item.id == item.id).FirstOrDefault().Equals(null))
                {
                    Picture p = new Picture();
                    p.imagePath = "http://localhost:34379/images/64.svg";
                    items[i].pictures.Add(p);
                }
                else
                {
                    Picture pic = _context.pictures.Where(p => p.item.id == item.id).FirstOrDefault();
                    pic.imagePath = "http://localhost:34379/" + pic.imagePath;
                    pic.owner = null;
                    items[i].pictures.Add(pic);
                }
            }
            return (items);
        }

        private bool ItemExists(int id)
        {
            return _context.items.Any(e => e.id == id);
        }
    }
}