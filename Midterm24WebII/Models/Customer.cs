using System.ComponentModel.DataAnnotations;

namespace Midterm24WebII.Models
{
    public class Customer
    {
        [Key]
        public long? CustomerID { get; set; }
        
        public string CustomerName { get; set; }

        public string CustomerTitle { get; set; }

        public double CustomerPay { get; set; }
    }
}
