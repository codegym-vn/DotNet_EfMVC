
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Entities;
using ProductManagement.Services;

namespace ProductManagement.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/user")]
    public class UserController : GeneralController<User, IUserService>
    {
        public UserController(IUserService service) : base(service)
        {

        }
    }
}
