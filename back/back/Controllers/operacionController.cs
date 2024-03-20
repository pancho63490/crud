using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace back.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class operacionController : Controller
  {
    [HttpGet]
    public decimal Get(decimal a, decimal b)
    {
      return a + b;
    }

    [HttpPost]
    public decimal Add(decimal a, decimal b, [FromHeader] string Host)
    {
      Console.WriteLine(Host);
      return a - b;
    }

    [HttpDelete]
    public decimal delete(decimal a, decimal b)
    {
      return a / b;
    }

    [HttpPut]
    public decimal put(decimal a, decimal b)
    {
      return a * b;
    }

  }
}

