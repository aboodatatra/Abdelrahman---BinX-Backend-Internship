
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<string> Items = new()
        {
            "Laptop",
            "Mouse",
            "Keyboard"
        };

        [HttpGet]
        public ActionResult<List<string>> GetItems()
        {
            return Ok(Items);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetItem(int id)
        {
            if (id < 0 || id >= Items.Count)
                return NotFound();

            return Ok(Items[id]);
        }
    }
}