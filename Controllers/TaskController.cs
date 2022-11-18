namespace asv.Controllers;
using Microsoft.AspNetCore.Mvc;
using asv.Actions;

[Route("/api/[controller]")]
[ApiController]

public class TaskController : ControllerBase
{
    // GET api/task
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        Task Todo = new Task();
        Todo.Name = "New";
        Todo.Status = "Started";

        return new JsonResult(new { data = Todo.Name });
    }

    // GET api/task/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "value";
    }

    // POST api/task
    [HttpPost]
    public void Post([FromBody] string value)
    { 
    }

    // PUT api/task/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {   
    }

    // DELETE api/task/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {  
    }
}