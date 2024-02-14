using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Midterm24WebII.Models.DBEntitys
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string firstName {get; set;}
        public string lastName {get; set;}
        public DateTime DateOfBirth { get; set;}
        public string Email { get; set;}
        public double Salary { get; set;}
    }
}
