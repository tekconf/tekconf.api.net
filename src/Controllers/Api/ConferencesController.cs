using Microsoft.AspNet.Mvc;

namespace TekConf.Api
{
    [Route("api/[controller]")]
    public class ConferencesController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return null;
        }
    }
}