using eShopSolution.Application.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IPublicProductService _productService;
        public ProductController( IPublicProductService productService)
        {
            _productService = productService;
        }
       [HttpGet]
       public async Task<ActionResult> Get()
        {
            var product = await _productService.GetAll();
            return Ok(product);
        }
    }
}
