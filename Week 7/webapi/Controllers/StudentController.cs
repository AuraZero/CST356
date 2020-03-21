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
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllProducts()
        {
            var result = _dbContext.Student.ToList();
            return Ok(result);
        }

        [HttpGet("{productId}")]
        public ActionResult<Student> GetProduct(int productId)
        {
            var product = _dbContext.Student
                .SingleOrDefault(p => p.studentId == productId);

            if (product != null) {
                return product;
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Student> AddProduct(Student product)
        {
            _dbContext.Student.Add(product);
            _dbContext.SaveChanges();

            // return CreatedAtAction(nameof(GetProduct), new { id = product.studentId }, product);

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpDelete("{studentId}")]
        public ActionResult DeleteProduct(int productId)
        {
            var product = new Student { studentId = productId };

            _dbContext.Student.Attach(product);
            _dbContext.Student.Remove(product);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut("{studentId}")]
        public ActionResult UpdateProduct(int productId, Student productUpdate)
        {
            var product = _dbContext.Student
                .SingleOrDefault(p => p.studentId == productId);

            if (product != null)
            {
                product.studentId = productUpdate.studentId;
                product.emailAddress = productUpdate.emailAddress;

                _dbContext.Update(product);

                _dbContext.SaveChanges();
            }

            return NoContent();
        }
    }
}