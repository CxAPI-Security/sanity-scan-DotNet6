using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sanity_project_csharp.Controllers;

[Route("api/[controller]")]
public class StudentController : Controller
{
    private Student st1 = new Student(1, "Test Student", "Somewhere in Portugal", "Braga", "Portugal");
    private Student st2 = new Student(2, "Test Student 2", "Somewhere in Portugal 2", "Braga", "Portugal");

    private readonly Dictionary<int, Student> _students = new();
    public StudentController()
    {
        _students.Add(st1.StudentId, st1);
        _students.Add(st2.StudentId, st2);
    }


    // GET: api/student
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Student>), 200)]
    [ProducesResponseType(404)]
    public ActionResult Get()
    {
        if (_students.Count == 0)
        {
            return Problem(detail: "No items Found");
        }

        return Ok(_students.Values.ToList());
    }

    // GET api/student/5
    [HttpGet("{id}")]
    public Student Get(int id)
    {
        return _students[id];
    }

    // POST api/student
    [HttpPost]
    public void Post([FromBody] Student st)
    {
        _students.Add(st.StudentId, st);
    }

    // PUT api/student/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Student st)
    {
        _students.Add(id, st);
    }

    // DELETE api/student/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _students.Remove(id);
    }

    [HttpGet("dummy")]
    public Dummy Dummy(Dummy du)
    {
        return du;
    }

    [HttpPost("list")]
    public List<int> getList([FromBody] ISet<int> ids)
    {
        return ids.ToList();
    }
}