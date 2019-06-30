using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyAngularApp.Controllers
{
    [Route("api/[Controller]")]
    public class TestController : Controller
    {
        [HttpGet("/api/info/")]
        public IEnumerable<string> Get()
        {
            return new string[] { "" };
        }
    }
}
