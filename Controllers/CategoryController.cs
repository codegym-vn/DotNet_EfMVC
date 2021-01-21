
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Entities;
using ProductManagement.Services;
 

namespace ProductManagement.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/category")]
    public class CategoryController : GeneralController<Category, ICategoryService>
    {
        public CategoryController(ICategoryService service) : base(service)
        {

        }
    }
}
