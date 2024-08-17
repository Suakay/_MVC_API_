using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace _MVC_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            BackgroundJob.Enqueue(() => BackgroundTestServices.Test());
            return Ok("Hangfire çalıştı");
        }
    }
    public class BackgroundTestServices
    {
        public static void Test()
        {
            Console.WriteLine("Hangfire çalışıyor:"  +DateTime.Now);
        }
    }
}
