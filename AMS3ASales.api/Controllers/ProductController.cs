using AMS3ASales.api.Context;
using AMS3ASales.api.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AMS3ASales.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDataContext _context;
        public ProductController(ApplicationDataContext context)
        {
            _context = context;
        }
         
        [HttpGet]

        public ActionResult<IEnumerable<Product>> Get()
        {
            return _context.Product.ToList();
        }
        
        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<Product> GetByProductId(Guid id)
        {
            var product = _context.Product.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);

        }
        [HttpPost]
    
        public ActionResult Post(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
            return Ok();


        }
    }
}
