using System;
using Microsoft.AspNetCore.Mvc;

namespace DeserializeTest.Controllers
{
    [Route("Tests")]
    public class TestController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public IActionResult Post(Thing thing)
        {
            return new OkObjectResult(thing);
        }
    }

    public class Thing
    {
        public DateTimeOffset Date { get; set; }
    }
}