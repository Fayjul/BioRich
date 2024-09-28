using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "This is the all products";
        }
        [HttpGet(":id")]
        public string GetProduct(int id)
        {
            return $"We are searching product by id = {id}";
        }
    }
}