using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Models;  // ✅ Import Student model

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        public string GetDateTime()
        {
            return System.DateTime.Now.ToString();
        }

        [HttpGet("GetRegionTime")]
        public string GetRegionTime([FromQuery] string region)
        {
            return region + " " + System.DateTime.Now.ToString();
        }

        [HttpGet("GetName")]
        public string GetName([FromQuery] string firstname, [FromQuery] string lastname)
        {
            return firstname + " " + lastname;
        }

        [HttpGet("GetStudent")]
        public Student GetStudent([FromQuery] int Id, [FromQuery] string Name)
        {
            Student student = new Student();  // ✅ Fixed case sensitivity
            student.Name = Name;
            student.Id = Id;  // ✅ Fixed property name
            return student;
        }
    }
}
