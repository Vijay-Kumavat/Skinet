using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string products()
        {
            return "The list of products";
        }

        [HttpGet("{id}")]
        public string product(int id)
        {
            return "Single product";
        }
    }
}