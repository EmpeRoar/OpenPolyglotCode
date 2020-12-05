using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Api.Controllers
{
    public class Shit
    {
        public string Name { get; set; }
    }


    [ApiController]
    [Route("api/[controller]")]
    public class LazinessController : ControllerBase
    {
        private Lazy<Shit> lazyShit = new Lazy<Shit>();
        private Lazy<int> lazyInt = new Lazy<int>(() => Thread.CurrentThread.ManagedThreadId);
        public LazinessController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            lazyShit.Value.Name = "His shitness";
            return Ok(lazyShit.Value.Name);
        }
    }
}
