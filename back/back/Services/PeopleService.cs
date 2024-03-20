using System;
using back.Controllers;

namespace back.Services
{
  public class PeopleService: IPeopleInterface
  {
    public bool Validate(People people)
    {
      if (string.IsNullOrEmpty(people.Name)|| people.Name.Length >100)
      {
        return false;
      }
      return true;
    }
  }
}

