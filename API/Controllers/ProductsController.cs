using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepositoy;

        public ProductsController(IProductRepository productRepositoy)
        {
            this._productRepositoy = productRepositoy;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _productRepositoy.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _productRepositoy.GetProductByIdAsync(id);
            return Ok(product);
        }

    }
}