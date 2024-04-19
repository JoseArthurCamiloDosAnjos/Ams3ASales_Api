using AMS3ASales.api.Context;
using AMS3ASales.api.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AMS3ASales.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ApplicationDataContext _context;
        public CategoriaController(ApplicationDataContext context)
        {
            _context = context;
        }
        //Procurar Dados
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return _context.Categoriy.ToList();
        }
        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<Category>GetByCategoryId(Guid id)
        {
            var category = _context.Categoriy.FirstOrDefault(c => c.Id == id);
            if (category == null)return NotFound();
            return Ok(category);
            
        }
        [HttpPost]
        //Enviar Dados
        public ActionResult Post(Category category)
        {
            _context.Categoriy.Add(category);
            _context.SaveChanges();
            return Ok();

        }
        
        
        }
}

