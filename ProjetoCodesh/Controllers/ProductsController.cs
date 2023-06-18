using Microsoft.AspNetCore.Mvc;
using ProjetoCodesh.Data.Repositories;
using ProjetoCodesh.Models;
using ProjetoCodesh.Models.InputModels;
using System.Collections.Generic;


namespace ProjetoCodesh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProductsRepository _productsRepository;


        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;

        }
        // GET: api/<ProductsController>
        [HttpGet]
        public IActionResult Get()
        {
            var response = _productsRepository.Buscar();
            return Ok(response);
        }

        // GET api/<ProductsController>/{codde}
        [HttpGet("{code}")]
        public IActionResult Get(long code)
        {
            var product = _productsRepository.Buscar(code);

            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] ProductsInputModel newProduct)
        {
            var product = new Product(newProduct.Code, newProduct.Product_name);
            _productsRepository.Adicionar(product);
            return Created("", product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{code}")]
        public IActionResult Put(long code, [FromBody] ProductInputModelPut productUpdate) 
        {
            var product = _productsRepository.Buscar(code);

            if(product == null)
            {
                return NotFound();
            }

            product.UpdateProduct(productUpdate.Product_name, productUpdate.Status, productUpdate.Ingredients_text);

            _productsRepository.Atualizar(code, product);

            return Ok(product);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{code}")]
        public IActionResult Delete(long code)
        {
            var product = _productsRepository.Buscar(code);
            if (product == null)
            {
                return NotFound();
            }

            _productsRepository.Delete(code);

            return NoContent();
        }
    }
}
