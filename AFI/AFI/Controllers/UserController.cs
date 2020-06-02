using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AFI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            return new JsonResult("Success");
        }
    }
}
