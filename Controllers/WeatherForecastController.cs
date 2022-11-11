using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace Simple_api.Controllers
{
    [ApiController]
    [Route("bootcamp/4/[controller]")]
    public class PeopleController : ControllerBase
    {
        private static readonly string[] bootcamp_test = new[]
        {
        "Persona1","Persona2","Persona3"
    };

        private readonly ILogger<PeopleController> _logger;

        public PeopleController(ILogger<PeopleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "bootcamp/{int id}/people")]
        public HttpResponseMessage getPeople(int id)
        {
            if (id == 4)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
                //return Request.CreateResponse<string[]>(HttpStatusCode.OK, bootcamp_test);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.NoContent);

            }
        }
    }
}