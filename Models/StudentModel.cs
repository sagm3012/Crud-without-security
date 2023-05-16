using UzInfoComStudents.Core.Enuns;

namespace UzInfoComStudents.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Teacher { get; set; }
        public DateTime ContractDate { get; set; }
        public decimal Contrakt { get; set; }
        public StudentStatus Status { get; set; }

    }
}
