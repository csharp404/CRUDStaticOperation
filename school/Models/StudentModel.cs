using System.Security.Cryptography.X509Certificates;

namespace school.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string CourseName { get; set; }
    }
}
