using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sanity_project_csharp.Controllers
{



    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private Student st1 = new Student(1, "Test Student", "Somewhere in Portugal", "Braga", "Portugal");
        private Student st2 = new Student(2, "Test Student 2", "Somewhere in Portugal 2", "Braga", "Portugal");

        private Dictionary<int, Student> students = new Dictionary<int, Student>();

        public StudentController()
        {
            students.Add(st1.StudentId,st1);
            students.Add(st2.StudentId,st2);

        }



        // GET: api/student
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Student>), 200)]
        [ProducesResponseType(404)]
        public ActionResult Get()
        {
            if (students.Count == 0)
            {
                return Problem(detail: "No items Found");
            }

            return Ok(students.Values.ToList());
        }

        // GET api/student/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return students[id];
        }

        // POST api/student
        [HttpPost]
        public void Post([FromBody] Student st)
        {
            students.Add(st.StudentId, st);
        }

        // PUT api/student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student st)
        {
            students.Add(id, st);
        }

        // DELETE api/student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.Remove(id);
        }

        [HttpGet("dummy")]
        public Dummy Dummy(Dummy du)
        {
            return du;
        }
    }
}

