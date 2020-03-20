using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        [HttpGet]
        public List<Instructor> Get()
        {
            List<Instructor> instructorList = new List<Instructor>();

            foreach (Instructor anInstructor in Database.InMemory.Instructors)
            {
                instructorList.Add(anInstructor);
            }
            return instructorList;
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