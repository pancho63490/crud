using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs;
using back.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace back.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
    IPostService _titlesServie;
    public PostController(IPostService titleService)
    {
      _titlesServie = titleService;
    }

    [HttpGet]
    public async Task<IEnumerable<PostDto>> Get() =>
      await _titlesServie.Get();
    }
}

