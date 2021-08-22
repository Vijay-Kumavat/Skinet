using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet, Route("GetProduct")]
        public async Task<ActionResult<List<TbProduct>>> GetProduct()
        {
            return Ok(await _context.Product.ToListAsync());
        }

        [HttpGet, Route("GetProduct/{id}")]
        public async Task<ActionResult<TbProduct>> GetOneProduct(int id)
        {
            return await _context.Product.FindAsync(id);
        }
    }
}