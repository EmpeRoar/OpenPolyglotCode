using CSharp.Api.Data;
using CSharp.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        AppDbContext _ctx;
        public TestController(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        private IQueryable<T> DoGetData<T>(IQueryable<T> dbset) where T : class, ICorex
        {
            return dbset;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _ctx.TestItems.ToListAsync());
        }

        [HttpGet]
        [Route("shit")]
        public async Task<IActionResult> Get2()
        {
            var c = DoGetData<TestItem>(_ctx.TestItems).ToList();
            return Ok(c);
        }

        [HttpGet]
        [Route("any")]
        public async Task<IActionResult> GetAny()
        {
            var d = DoGetData<TestItem>(_ctx.TestItems);
            var cx = d.Cast<ICorex>().Where(x => x.ID.Equals(1));
            var r = cx.Any();
            return Ok(r);
        }

        [HttpGet]
        [Route("better")]
        public async Task<IActionResult> GetBetter()
        {
            var d = _ctx.ExistResult.FromSqlRaw("Select TOP 1 ID From [cx-local].[CX].[TestItem] where BID = 1 AND ID = 1");
            var x = d.ToList();

            return Ok(x);
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
