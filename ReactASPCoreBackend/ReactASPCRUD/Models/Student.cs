using System.ComponentModel.DataAnnotations;

namespace ReactASPCRUD.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }

        public string studentName { get; set; }

        public string course { get; set; }
    }
}
