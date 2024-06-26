using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FakeXiecheng.API.Controllers
{
    [Route("api/shoudongapi")]
    public class ShoudongAPIController : ControllerBase
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "valu2" };
        }
    }
}
