using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/product")]
    public class ProductController: ControllerBase
    {
    }
}
