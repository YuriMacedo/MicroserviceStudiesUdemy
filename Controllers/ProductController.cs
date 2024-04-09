using GeekShopping.ProdutAPI.Data.ValueObjects;
using GeekShopping.ProdutAPI.Model;
using GeekShopping.ProdutAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProdutAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        [HttpGet]
        public async Task<ActionResult<ProductVO>> GetAll()
        {
            var products = await _repository.GetAll();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(long id) 
        {
            var product = await _repository.FindById(id);

            if (product == null) return NotFound();
                
            return Ok(product);

        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ProductVO product) 
        {

            if (product == null) return BadRequest();

            var productCreated = await _repository.Create(product);
            
            return Ok(productCreated);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] ProductVO product)
        {
            if (product == null) return BadRequest();

            var productUpdated = await _repository.Update(product);

            return Ok(productUpdated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.DeleteById(id);

            if (!status) return BadRequest();

            return Ok(status);
        }
    }
}
