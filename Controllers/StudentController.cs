using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using UzInfoComStudents.Core;
using UzInfoComStudents.Core.Entity;
using UzInfoComStudents.Core.Enuns;
using UzInfoComStudents.Core.Interface;
using UzInfoComStudents.Data;
using UzInfoComStudents.Models;

namespace UzInfoComStudents.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class StudentController : ControllerBase
    {
        private readonly IStudentService iStudentService;
        public StudentController(IStudentService _iStudentService)
        {
            iStudentService = _iStudentService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = iStudentService.GetAll();

            return Ok(result);
        }

        [HttpGet("GetStudentById")]

        public IActionResult GetById(int id)
        {
            var result = iStudentService.GetById(id);
            if (result != null)
                return Ok(result);
            else return NoContent();
        }

        [HttpGet("GetStudentByName")]

        public IActionResult GetByName(string name)
        {
            var result = iStudentService.GetByName(name);
            if (result != null)
                return Ok(result);
            else return NoContent();
        }

          [HttpPost]

        public async Task<IActionResult> SaveSudent(StudentModel student)
        {
           var result=  iStudentService.SaveStudent(student);
            return Ok(result);
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var result = iStudentService.DeleteById(id);
            return Ok(result);
        }

    } 
}
