using Microsoft.AspNetCore.Mvc;
using Midterm24WebII.DAL;
using Midterm24WebII.Models;

namespace Midterm24WebII.Controllers
{
    public class ContactController : Controller
    {
        private readonly EmployeeDbContext _context;
        public ContactController(EmployeeDbContext context)
        {
            this._context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [Route("ContactUs/ContactUs")]
        public ActionResult ContactUs()
        {
            var employees =_context.Employee.ToList();
            if(employees != null)
            {
                List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();
                foreach(var employee in employees)
                {
                    var EmployeeViewModel = new EmployeeViewModel()
                    {
                        Id = employee.Id,
                        firstName = employee.firstName,
                        lastName = employee.lastName,
                        DateOfBirth = employee.DateOfBirth,
                        Email = employee.Email,
                        Salary = employee.Salary
                    };
                    employeeList.Add(EmployeeViewModel);
                }
                return View(employeeList);
            }
            return View();
            
        }
        
    }
}
