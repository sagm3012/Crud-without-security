using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using UzInfoComStudents.Core.Entity;
using UzInfoComStudents.Core.Interface;
using UzInfoComStudents.Data;
using UzInfoComStudents.DB;
using UzInfoComStudents.Models;

namespace UzInfoComStudents.Core
{

    public class StudentService : IStudentService
    {
        public readonly StudentDbContext _studentDbContext;

        public StudentService(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        string IStudentService.DeleteById(int id)
        {
             var query = _studentDbContext.Students.FirstOrDefault(a=>a.Id==id);
            if (query == null)
            {
                return "No student found";
            }
            _studentDbContext.Remove(query);
           
            return "successful deleted";

        }

        public async Task<List<Student>> GetAll()
        {
            var query = _studentDbContext.Students.ToList();
            return query;
        }

       public  StudentModel GetById(int id)
        {
            StudentModel model = new StudentModel();
            var query = _studentDbContext.Students.FirstOrDefault(a => a.Id == id);

           if(query != null)
            {
                model.Name = query.Name;
            }
            return model;
        }

        List<StudentModel> GetByName(string name)
        {
            var query =StudentDB.GetAllStudents().FindAll(a => a.Name == name);
            return query;
        }

        Student IStudentService.SaveStudent(StudentModel student)
        {
            var ent = new Student();
            ent.Id = student.Id;
            ent.Name = student.Name;
            ent.Country = student.Country;
            ent.Teacher = student.Teacher;
            ent.ContractDate = student.ContractDate;
            ent.Contrakt = student.Contrakt;
            ent.StudentStatus = student.Status;
            _studentDbContext.Students.Add(ent);
            _studentDbContext.SaveChanges();
            
            return ent;
        }

        List<StudentModel> IStudentService.GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}