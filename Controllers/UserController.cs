
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Constant;
using ProductManagement.Entities;
using ProductManagement.Services;
using WebApi.Constant;

namespace ProductManagement.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/user")]
    public class UserController : GeneralController<User, IUserService>
    {
        private Response response;
        private IUserService _userService;
        public UserController(IUserService userService) : base(userService)
        {
            response = new Response();
            _userService = userService;
        }


        [AllowAnonymous]
        [HttpPost("login")]
        public Response Login([FromBody] Authenticate model)
        {
            var user = _userService.Login(model.Username, model.Password);
            response.Data = user;
            if (user != null)
            {
                response.Status = (int) Configs.STATUS_SUCCESS;
                response.Message = "Success";
            }
            else
            {
                response.Status = (int)Configs.STATUS_ERROR;
                response.Message = "Username or Password invalid";
            }
            return response;
        }
    }
}
