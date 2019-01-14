using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		[Route("filter")]
		[HttpGet]
		public ActionResult<string> Get(bool value)
		{
			return $"Your value is {value}";
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return $"value {id}";
		}

		// POST api/values
		[HttpPost]
		public ActionResult<string> Post([FromBody] string value)
		{
			return $"Posted value {value}";
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public ActionResult<string> Put(int id, [FromBody] string value)
		{
			return $"Put value => id:{id}, content: {value}";
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public ActionResult<string> Delete(int id)
		{
			return $"Deleted value {id}";
		}
	}
}
