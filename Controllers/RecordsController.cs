using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DR_records.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {

        private RecordsRepository _recordsRepository;

        
        public RecordsController(RecordsRepository _recordslib) 
        {
            _recordsRepository = _recordslib; 
        }

        // GET: api/<RecordsController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public IEnumerable<Records> Get()
        {
            return _recordsRepository.Get();
        }

        // GET api/<RecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<RecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
