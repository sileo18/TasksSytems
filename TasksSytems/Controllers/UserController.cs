using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TasksSytems.Models;

namespace TasksSytems.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> SearchAllUsers()

        {
            return Ok();
        }
    }
}
