using UzInfoComStudents.Core.Entity;
using UzInfoComStudents.Models;

namespace UzInfoComStudents.Core.Interface
{
    public interface IStudentService
    {
        Task<List<Student>> GetAll();
        StudentModel GetById(int id);
        List<StudentModel> GetByName(string name);
        Student SaveStudent(StudentModel student);
        String DeleteById(int id);
    }
}
