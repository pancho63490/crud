using System;
using back.DTOs;

namespace back.Services
{
  public interface IPostService
  {
    public  Task<IEnumerable<PostDto>> Get(); 

  }
}

