
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
        private ICategoryService service;
        public CategoryController(ICategoryService _service) : base(_service)
        {
            service = _service;
        }
        public void Add()
        {
            service.Add(new Category());
        }

    }
}
