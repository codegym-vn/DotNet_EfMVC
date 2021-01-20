
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Constant;
using ProductManagement.Services;
using WebApi.Constant;

namespace ProductManagement.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private Response response;
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            response = new Response();
            _userService = userService;
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
