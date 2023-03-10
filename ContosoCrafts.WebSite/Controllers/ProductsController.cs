using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService) 
        {
            this.ProductService = productService;
        }
        public JsonFileProductService ProductService { get; }

        public IEnumerable<Product> Get() 
        {
            return ProductService.GetProducts();
        }
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery]string ProductId, 
            [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}
