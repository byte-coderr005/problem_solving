using apirest1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apirest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new()
        {
            new Product { Id = 1, Name = "Keyboard", Price = 599.99m},
            new Product { Id = 2, Name = "Mouse", Price = 249.50m},
            new Product { Id = 3, Name = "Monitor", Price = 600.00m}
        };
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
       => Ok(products);

        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpGet("expensive")]
        public ActionResult<IEnumerable<Product>> GetExpensive([FromQuery] decimal minPrice = 0,decimal maxPrice = 1000)
        {
            if(minPrice > maxPrice)
                return BadRequest("min Price cannot be greter than max price");
            var result = products.Where(x => x.Price > minPrice && x.Price < maxPrice).ToList();
            
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<Product> Create(Product newProduct)
        {
            newProduct.Id = products.Max(p => p.Id) + 1;
            products.Add(newProduct);
            return CreatedAtAction(nameof(GetById), new { id = newProduct.Id }, newProduct);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updated)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            product.Name = updated.Name;
            product.Price = updated.Price;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            products.Remove(product);
            return NoContent();
        }

    }
}
