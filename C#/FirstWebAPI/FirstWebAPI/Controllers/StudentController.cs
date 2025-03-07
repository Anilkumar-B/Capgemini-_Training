using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Models;

namespace FirstWebAPI.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]  // Ensure correct route definition
    public class StudentController : ControllerBase
    {
        private static readonly List<Student> students = new List<Student>();  // Made list readonly for better encapsulation

        // GET: Retrieve all students
        [HttpGet]
        public ActionResult<List<Student>> GetStudents()
        {
            return Ok(students);  // Use ActionResult for better HTTP responses
        }

        // POST: Add a new student
        [HttpPost]
        public ActionResult<string> AddStudent([FromBody] Student student)
        {
            if (student == null || string.IsNullOrEmpty(student.Name))
            {
                return BadRequest("Invalid student data.");
            }

            students.Add(student);
            return Ok($"{student.Id} - {student.Name} Record inserted successfully");
        }

        // PUT: Update an existing student
        [HttpPut]
        public ActionResult<string> UpdateStudent([FromBody] Student student)
        {
            var studentToUpdate = students.FirstOrDefault(s => s.Id == student.Id);
            if (studentToUpdate == null)
            {
                return NotFound($"Student with ID {student.Id} not found.");
            }

            studentToUpdate.Name = student.Name;
            return Ok($"{student.Id} - {student.Name} Record updated successfully");
        }

        // DELETE: Remove a student by ID
        [HttpDelete("{id}")]  // Using route parameter for better API design
        public ActionResult<string> DeleteStudent(int id)
        {
            var studentToDelete = students.FirstOrDefault(s => s.Id == id);
            if (studentToDelete == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }

            students.Remove(studentToDelete);
            return Ok($"{studentToDelete.Id} - {studentToDelete.Name} Record deleted successfully");
        }
    }
}
