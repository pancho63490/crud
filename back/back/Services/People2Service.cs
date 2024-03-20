using System;
using back.Controllers;

namespace back.Services
{
  public class People2Service: IPeopleInterface
  {
    public bool Validate(People people)
    {
      if (string.IsNullOrEmpty(people.Name)|| people.Name.Length >100|| people.Name.Length < 1)
      {
        return false;
      }
      return true;
    }
  }
}

