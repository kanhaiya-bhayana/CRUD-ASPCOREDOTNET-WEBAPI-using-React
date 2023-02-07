using System.ComponentModel.DataAnnotations;

namespace ReactASPCRUD.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Required] public string name { get; set; }

        [Required] public string mobile { get;set; }
        [Required] public string email { get;set; }

        [Required]
        public string password { get; set; } = null!;

    }
}
