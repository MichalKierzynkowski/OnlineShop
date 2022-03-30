using Application.Dto.Product;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductRepository:ControllerBase
    {

        private readonly IProductService _productService;
        public ProductRepository(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet]
        [SwaggerOperation(Summary = "Retrieves all products")]
        public IActionResult GetAll()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Retrieves one product by Id")]
        public IActionResult GetById(Guid id)
        {
            var product = _productService.GetProductById(id);
            return Ok(product);
        }
        [HttpPost]
        [SwaggerOperation(Summary = "Create new Product")]
        public IActionResult Create(CreateProductDto newProduct)
        {
            var product = _productService.AddNewProduct(newProduct);
            return Created($"api/product/{product.Id}", newProduct);

        }
    }
}
