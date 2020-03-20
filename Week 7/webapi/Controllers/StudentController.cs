using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public List<Student> Get()
        {
            List<Student> studentList = new List<Student>();

            foreach (Student aStudent in Database.InMemory.Students)
            {
                studentList.Add(aStudent);
            }
            return studentList;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Student student)
        {
            student.Id = getNextId();

            InMemory.Students.Add(student);

            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            
            var student = InMemory.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }

        private List<Student> getStudents()
        {
            return InMemory.Students;
        }  

        private int getNextId()
        {
            return InMemory.Students.Max(p => p.Id) + 1;
        }
    }
}