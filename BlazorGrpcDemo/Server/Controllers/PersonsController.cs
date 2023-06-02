using Microsoft.AspNetCore.Mvc;
using BlazorGrpcDemo.Server.Data;
using BlazorGrpcDemo.Shared;

namespace BlazorGrpcDemo.Server.Controllers;

[Route("[controller]")]
[ApiController]
public class PersonsController : Controller
{
	PersonsManager personsManager;

	public PersonsController(PersonsManager _personsManager)
	{
		personsManager = _personsManager;

	}

	[HttpGet]
	public List<Person> GetAll()
	{
		return personsManager.People;
	}

	[HttpGet("{Id}/getbyid")]
	public Person GetPersonById(int Id)
	{
		return (from x in personsManager.People
					  where x.Id == Id
					  select x).FirstOrDefault();
	}
}