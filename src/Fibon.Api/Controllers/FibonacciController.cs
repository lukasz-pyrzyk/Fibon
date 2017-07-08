using Fibon.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fibon.Api.Controllers
{
    [Route("[controller]")]
    public class FibonacciController : Controller
    {
        private readonly IRepository _repository;

        public FibonacciController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{number}")]
        public IActionResult Get(int number)
        {
            return Content("0");
        }

        [HttpPost("{number}")]
        public IActionResult Post(int number)
        {
            return Accepted($"fibonacci/{number}", null);
        }
    }
}