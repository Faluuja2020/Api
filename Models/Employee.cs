using System.ComponentModel.DataAnnotations;

namespace EmployeRazor.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(0, 200)]
        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }
    }
}
