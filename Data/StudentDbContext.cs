using Microsoft.EntityFrameworkCore;
using UzInfoComStudents.Core.Entity;
using UzInfoComStudents.Models;

namespace UzInfoComStudents.Data
{

    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) 
            : base(options) 
        {
            
        }

        
        public DbSet<Student> Students { get; set; }   
    }
}
