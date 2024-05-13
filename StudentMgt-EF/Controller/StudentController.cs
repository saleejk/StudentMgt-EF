using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentMgt_EF.ModelEntity;
using StudentMgt_EF.Service;

namespace StudentMgt_EF.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudent _iStudents;
        public StudentController(IStudent istudents)
        {
            _iStudents = istudents;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_iStudents.GetAllStudents());
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            return Ok(_iStudents.GetStudentById(id));
        }

        [HttpGet("age")]
        public IActionResult FilterByAge(int age)
        {
            return Ok(_iStudents.FilterStudentByAge(age));
        }
        [HttpGet("name")]
        public IActionResult SearchName(string name)
        {
            return Ok(_iStudents.SearchStudentByName(name));
         }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _iStudents.AddStudent(student);
            return Ok("added completed");
        }
    }
}
