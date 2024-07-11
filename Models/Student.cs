using System.ComponentModel.DataAnnotations;

namespace _200552678.Models
{
    public class Student
    {
        [Required]
        public int StudentID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public decimal LastName { get; set; }

        public string EmailAddress { get; set; }
    }
}
