
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Constant; 
using ProductManagement.Services.CategoryService;
using WebApi.Constant;

namespace ProductManagement.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private Response response;
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            response = new Response();
            _categoryService = categoryService;
        }

        [HttpGet]
        public Response Get()
        {
            var objectives = "";
            response.Status = (int)Config.STATUS_SUCCESS;
            response.Data = objectives;
            response.Message = "Success";
            return response;
        }

        [HttpGet]
        public Response Delete(int id)
        {
            var isDeleted = false;
            response.Status = (int)Config.STATUS_SUCCESS;
            response.Data = isDeleted;
            response.Message = "Success";
            return response;
        }
    }
}
