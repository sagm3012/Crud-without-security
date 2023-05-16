using Microsoft.SqlServer.Server;
using System.Globalization;
using UzInfoComStudents.Core.Enuns;
using UzInfoComStudents.Models;

namespace UzInfoComStudents.DB
{
    public static class StudentDB
    {
        private const string Format = "yyyy-MM-dd";

        public static List<StudentModel> GetAllStudents() 
        {

            List<StudentModel> list= new List<StudentModel>();
            list.Add(new StudentModel()
            {
                Id= 1,
                Name= "Sadio",
                Country="Senegal",
                Teacher="Thomas",
                ContractDate = DateTime.ParseExact("2019-04-30",
                        Format, CultureInfo.InvariantCulture),
                Contrakt = 7310000,
                Status = StudentStatus.NEGOTIATION
            });
            list.Add(new StudentModel()
            {
                Id = 2,
                Name = "Leo",
                Country = "Argentina",
                Teacher = "Xavi",
                ContractDate = DateTime.ParseExact("2022-07-13",
                        Format, CultureInfo.InvariantCulture),
                Contrakt = 3500000,
                Status = StudentStatus.RENEWAL
            });
            list.Add(new StudentModel()
            {
                Id = 3,
                Name = "Cristiano",
                Country = "Portugal",
                Teacher = "Fergisson",
                ContractDate = DateTime.ParseExact("2012-11-30",
                        Format, CultureInfo.InvariantCulture),
                Contrakt = 6310000,
                Status = StudentStatus.NEGOTIATION
            });
            return list;

        }
    }
}