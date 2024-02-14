using System.ComponentModel;

namespace Midterm24WebII.Models
{
    public class EmployeeViewModel
    {
        
        
        public int Id { get; set; }
        [DisplayName("FirstName")]
        public string firstName { get; set; }
        [DisplayName("LastName")]
        public string lastName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        public double Salary { get; set; }

        [DisplayName("Name")]
        public string FullName
        {
            get { return firstName + " " + lastName; }
        }
    }
}
