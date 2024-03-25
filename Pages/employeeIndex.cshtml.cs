using ADO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADO.Pages
{
    public class employeeIndexModel : PageModel
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
        public List<Employee> employee { get; set; }
        public void OnGet()
        {
            employee = objemployee.GetEmployees().ToList();
        }
    }
}
