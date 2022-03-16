using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {

        private readonly ILogger<PersonsController> _logger;

        public PersonsController(ILogger<PersonsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            ICollection<Person> persons = new List<Person>();
            persons.Add(new Person(1, "Person 1", "Person 1 Description", 1, "url/1"));
            persons.Add(new Person(2, "Person 2", "Person 2 Description", 2, "url/2"));
            persons.Add(new Person(3, "Person 3", "Person 3 Description", 3, "url/3"));
            persons.Add(new Person(4, "Person 4", "Person 4 Description", 4, "url/4"));
            persons.Add(new Person(5, "Person 5", "Person 5 Description", 5, "url/5"));
            return persons;
        }
    }
}