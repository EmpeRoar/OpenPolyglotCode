using CSharp.Api.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        public TestController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TestItem test)
        {
            if (!TryValidateModel(test))
            {
                return new BadRequestResult();
            }
            return Ok();
        }

        public override bool TryValidateModel(object model)
        {
            byte x = 0;
            Task.Run(() =>
            {
                x = 3;
            });
            Console.WriteLine(x);
            return base.TryValidateModel(model);
        }

        public override bool TryValidateModel(object model, string prefix)
        {
            return base.TryValidateModel(model, prefix);
        }
    }
}
