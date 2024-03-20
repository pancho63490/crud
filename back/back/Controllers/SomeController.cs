using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace back.Controllers
{
    [Route("api/[controller]")]
    public class SomeController : Controller
    {
    [HttpGet("sync")]
    public IActionResult GetSync()
    {
      Stopwatch stopwatch = Stopwatch.StartNew();
      stopwatch.Start();
      Thread.Sleep(1000);
      Console.WriteLine("conexion a basede datos terminada");
      Thread.Sleep(1000);
      Console.WriteLine("conexion a correo terminada");
      Console.WriteLine("A terminado todo");
      stopwatch.Stop();
      return Ok(stopwatch.Elapsed);
    }
    [HttpGet("async")]
    public async Task<IActionResult> GetAsync()
    {

      Stopwatch stopwatch = Stopwatch.StartNew();
      stopwatch.Start();
      var task = new Task(() =>
      {
        Thread.Sleep(1000);
        Console.WriteLine("Conexion a base de datos Termionado");
      });
      var task2 = new Task(() =>
      {
        Thread.Sleep(1000);
        Console.WriteLine("Conexion correo  Termionado");
      });
      task.Start();
      task2.Start();
      Console.WriteLine("hago otra cosa");
      await task;
      await task2;
      Console.WriteLine("todo a terminado");
      stopwatch.Stop();
      return Ok(stopwatch.Elapsed);
    }
  }
}

