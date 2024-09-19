using E_Commerce_Udemy_Practice.Database;
using E_Commerce_Udemy_Practice.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Udemy_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            if (products.Any())
            {
                return Ok(products);
            }
            return BadRequest(products);
        }

        [HttpGet("GetProductById/{id:int}")]

        public ActionResult<Product> GetProductsById([FromRoute] int id)
        {
            //M1
            //var product = _context.Products.FirstOrDefault(x=>x.Id == id);
            //M2
            var product = _context.Products.Find(id);
            if(product is { })
            {
                return Ok(product);
            }
            return BadRequest($"No Products is Available with the ID: {id}");
        }
    }
}
