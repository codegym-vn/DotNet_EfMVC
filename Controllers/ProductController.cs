using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Entities;
using ProductManagement.Services;

namespace ProductManagement.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/product")]
    public class ProductController : GeneralController<Product, IProductService>
    {
        public ProductController(IProductService service) : base(service)
        {

        }
         
    }
}
