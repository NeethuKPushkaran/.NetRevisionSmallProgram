using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Small_Program.Models;

namespace Small_Program.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private static readonly List<Item> _items = new List<Item>
        {
            new Item { Id = 1, Name = "Item1", Price = 10, quantity = 2},
            new Item { Id = 2, Name = "Item2", Price = 12, quantity = 3},
            new Item { Id = 3, Name = "Item3", Price = 9, quantity = 4}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetItems()
        {
            return _items;
        }
    }
}
