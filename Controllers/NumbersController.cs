
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebNumarator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumbersController : ControllerBase
    {
        private static List<string> _numbers = new List<string>();

        [HttpGet]
        public IActionResult GetNumbers()
        {
            return Ok(_numbers);
        }

        [HttpPost]
        public IActionResult AddNumber([FromBody] string number)
        {
            if (_numbers.Count == 10)
            {
                _numbers.RemoveAt(0); // En eski numarayı kaldır
            }
            _numbers.Add(number);
            return Ok();
        }
    }
}
