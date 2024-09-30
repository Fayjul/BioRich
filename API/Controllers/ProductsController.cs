using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _contex;
        public ProductsController(StoreContext context)
        {
            _contex = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _contex.Products.ToListAsync();

            return Ok(products);
        }
        [HttpGet(":id")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _contex.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound("Please provide a valid id.");
            }
            return Ok(product);
        }
    }
}