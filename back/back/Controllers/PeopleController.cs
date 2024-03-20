using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using back.Services;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace back.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {

    private IPeopleInterface _peopleInterface;
    public PeopleController(IPeopleInterface peopleInterface)
    {
      _peopleInterface = peopleInterface;
    }
    [HttpGet("all")]
    public List<People> GetPeople() => Repository.People;
    [HttpGet("{id}")]
    public ActionResult<People> Get(int id) {

      var people= Repository.People.FirstOrDefault(p => p.id == id);

      if (people == null)
      {
        return NotFound();
      }
      else return Ok(people);
    }
    [HttpGet("search/{search}")]
    public List<People> Get(string search) =>
      Repository.People.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();

    
    [HttpPost]
    public IActionResult add(People people)
    {
      if (_peopleInterface.Validate(people))
      {
        return BadRequest();
      }
      else
      {
        Repository.People.Add(people);
        return NoContent();
      }
  
    }

  }



  public class Repository
  {
    public static List<People> People = new List<People>
    {
      new People()
      {
        id=1,
        Name="Juan",
        Birthdate = new DateTime(1990,12,3)
      },
      new People(){
        id=2,
        Name="Jose",
        Birthdate = new DateTime(1993,02,3)
      },  new People(){
        id=3,
        Name="Pedro",
        Birthdate = new DateTime(2012,05,3)
      }
    };

  }
  public class People
  {
    public int id { get; set; }
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
  }
}

